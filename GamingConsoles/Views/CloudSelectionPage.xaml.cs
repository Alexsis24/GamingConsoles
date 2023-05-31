namespace GamingConsoles.Views;

public partial class CloudSelectionPage : ContentPage
{
    public CloudSelectionPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        cloudConsoles.ItemsSource = GameConsolesServices.GetCloudConsoles();
    }
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
    async void Console_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new GameConsolePage(e.CurrentSelection.First() as GameConsole));
    }
}