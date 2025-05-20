using Microsoft.Maui.Controls;

namespace DentalClinic.MAUI.Views
{
    public partial class SideMenuView : ContentPage
    {
        public SideMenuView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        protected void OnHomeClicked(object sender, EventArgs e)
        {
            // Handle home menu click
            // You might want to navigate to a home page or perform other actions
            // For example:
            // await Shell.Current.GoToAsync("//home");
        }

        protected void OnDentistryClicked(object sender, EventArgs e)
        {
            // Handle dentistry menu click
            // You might want to navigate to the dentistry page or perform other actions
            // For example:
            // await Shell.Current.GoToAsync("//dentistry");
        }
    }

}