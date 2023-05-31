namespace GamingConsoles.Views;

public partial class ArcadeSelectionPage : ContentPage
{
    public ArcadeSelectionPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        arcadeConsoles.ItemsSource = GameConsolesServices.GetArcadeConsoles();
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }

    public async void SelectedConsolePage(System.Object sender, System.EventArgs e)
    {

        var selectedConsole = GameConsolesServices.GetArcadeConsoles()
               .Where(x => x.SystemName == "Donkey Kong")
			   ;
		foreach (var item in selectedConsole)
		{
            await Navigation.PushAsync(new GameConsolePage(item));
        }
        
    }   
}