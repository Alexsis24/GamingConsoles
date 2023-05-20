using GamingConsoles.Models;

namespace GamingConsoles.Views;

public partial class GameConsolePage : ContentPage
{
    public GameConsolePage()
    {
        InitializeComponent();
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}