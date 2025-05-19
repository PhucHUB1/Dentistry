using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Dentistry.Models;
using Dentistry.Services;

namespace Dentistry.ViewModels
{
    [QueryProperty(nameof(PatientId), "id")]
    public class PatientDetailsViewModel : BaseViewModel
    {
        private readonly IPatientService _patientService;
        private string _patientId;
        private Patient _patient;

        public string PatientId
        {
            get => _patientId;
            set
            {
                _patientId = value;
                LoadPatientAsync(value);
            }
        }

        public Patient Patient
        {
            get => _patient;
            set => SetProperty(ref _patient, value);
        }

        public ICommand BackCommand { get; }

        public PatientDetailsViewModel(IPatientService patientService)
        {
            Title = "Chi tiết bệnh nhân";
            _patientService = patientService;

            BackCommand = new Command(async () => await GoBack());
        }

        private async Task LoadPatientAsync(string patientId)
        {
            if (string.IsNullOrEmpty(patientId))
                return;

            try
            {
                IsBusy = true;
                Patient = await _patientService.GetPatientAsync(patientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading patient: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
