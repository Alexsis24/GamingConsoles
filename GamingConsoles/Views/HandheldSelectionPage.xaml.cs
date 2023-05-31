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
}