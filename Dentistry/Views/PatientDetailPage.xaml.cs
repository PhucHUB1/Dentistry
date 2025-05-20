using Dentistry.Services;
using Dentistry.ViewModels;

namespace Dentistry.Views;

public partial class PatientDetailPage : ContentPage
{
    private PatientDetailsViewModel _viewModel;

    public PatientDetailPage(PatientService patientService)
    {
        InitializeComponent();

        _viewModel = new PatientDetailsViewModel(patientService);
        BindingContext = _viewModel;
    }
}
