using Dentistry.Services;
using Dentistry.ViewModels;

namespace Dentistry.Views;

public partial class PatientListPage : ContentPage
{
    private PatientListViewModel _viewModel;
    public PatientListPage(PatientService patientService)
	{
		InitializeComponent();

        _viewModel = new PatientListViewModel(patientService);
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadPatients();
    }
}