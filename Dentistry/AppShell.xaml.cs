namespace Dentistry
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Views.PatientDetailPage), typeof(Views.PatientDetailPage));
        }
    }
 }

