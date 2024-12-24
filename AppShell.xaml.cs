using MobileAppDesigns.Views.PlantShop;

namespace MobileAppDesigns
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage));
        }
    }
}
