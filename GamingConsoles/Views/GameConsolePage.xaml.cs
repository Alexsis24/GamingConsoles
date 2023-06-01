using GamingConsoles.Models;

namespace GamingConsoles.Views;

public partial class GameConsolePage : ContentPage
{
    public GameConsolePage(GameConsole console)
    {
        InitializeComponent();
        this.BindingContext = console;
        //string AlternativeNamesOneString = "";
        //foreach (string name in console.AlternativeNames)
        //{
        //    AlternativeNamesOneString += name;
        //}
        //console.AlternativeNames = AlternativeNamesOneString;
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}