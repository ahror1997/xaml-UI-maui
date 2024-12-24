using MobileAppDesigns.Views.CarRent;
using MobileAppDesigns.Views.PlantShop;

namespace MobileAppDesigns;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void PlantShopBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignInPage));
    }

    private async void CarRentBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DetailsPage));
    }
}
