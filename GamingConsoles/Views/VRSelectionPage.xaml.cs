namespace GamingConsoles.Views;

public partial class VRSelectionPage : ContentPage
{
    public VRSelectionPage()
    {
        InitializeComponent();
    }
        protected override void OnAppearing()
    {
        base.OnAppearing();
        vrConsoles.ItemsSource = GameConsolesServices.GetVRConsoles();
    }
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}