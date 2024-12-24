using MobileAppDesigns.Views.CarRent;
using MobileAppDesigns.Views.PlantShop;

namespace MobileAppDesigns
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage));
            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        }
    }
}
