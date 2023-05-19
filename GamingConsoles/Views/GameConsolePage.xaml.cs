namespace GamingConsoles.Views;

public partial class GameConsolePage : ContentPage
{
    public GameConsolePage(GameConsole gameConsole)
    {
        InitializeComponent();
        this.BindingContext = gameConsole;

    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}