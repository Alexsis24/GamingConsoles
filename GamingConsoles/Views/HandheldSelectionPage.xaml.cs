namespace GamingConsoles.Views;

public partial class HandheldSelectionPage : ContentPage
{
    public HandheldSelectionPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        handheldConsoles.ItemsSource = GameConsolesServices.GetHandheldConsoles();
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