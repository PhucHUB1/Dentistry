using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Dentistry.Models;
using Dentistry.Services;

namespace Dentistry.ViewModels
{
    public class PatientListViewModel : BaseViewModel
    {
        private readonly IPatientService _patientService;
        private ObservableCollection<Patient> _patients;

        public ObservableCollection<Patient> Patients
        {
            get => _patients;
            set => SetProperty(ref _patients, value);
        }

        public ICommand LoadPatientsCommand { get; }
        public ICommand PatientTappedCommand { get; }

        public PatientListViewModel(IPatientService patientService)
        {
            Title = "Danh sách bệnh nhân";
            _patientService = patientService;
            Patients = new ObservableCollection<Patient>();

            LoadPatientsCommand = new Command(async () => await LoadPatients());
            PatientTappedCommand = new Command<string>(async (id) => await GoToPatientDetails(id));
        }

        public async Task LoadPatients()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var patients = await _patientService.GetPatientsAsync();
                Patients.Clear();
                foreach (var patient in patients)
                {
                    Patients.Add(patient);
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error loading patients: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task GoToPatientDetails(string id)
        {
            if (string.IsNullOrEmpty(id))
                return;

            
            await Shell.Current.GoToAsync($"PatientDetails?id={id}");
        }
    }
}
