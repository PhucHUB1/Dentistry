using Microsoft.Maui.Controls;

namespace DentalClinic.MAUI.Views
{
    public partial class SideMenuView : ContentView
    {
        public event EventHandler HomeClicked;
        public event EventHandler DentistryClicked;

        public SideMenuView()
        {
            InitializeComponent();
        }

        private void OnHomeClicked(object sender, EventArgs e)
        {
            HomeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void OnDentistryClicked(object sender, EventArgs e)
        {
            DentistryClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetActiveMenu(string menuName)
        {
            // Reset t?t c? các màu menu v? m?c ??nh
            HomeMenu.BackgroundColor = Color.FromArgb("#172554");
            DentistryMenu.BackgroundColor = Color.FromArgb("#172554");

            switch (menuName)
            {
                case "Home":
                    HomeMenu.BackgroundColor = Color.FromArgb("#2A3B75");
                    break;
                case "Dentistry":
                    DentistryMenu.BackgroundColor = Color.FromArgb("#2A3B75");
                    break;
            }
        }
    }
}