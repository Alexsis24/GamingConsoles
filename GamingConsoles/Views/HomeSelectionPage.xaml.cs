namespace GamingConsoles.Views;

public partial class HomeSelectionPage : ContentPage
{
	public HomeSelectionPage()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
