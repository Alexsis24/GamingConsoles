namespace GamingConsoles.Views;

public partial class ArcadeSelectionPage : ContentPage
{
	public ArcadeSelectionPage()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}