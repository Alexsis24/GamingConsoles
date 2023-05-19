namespace GamingConsoles.Views;

public partial class CloudSelectionPage : ContentPage
{
	public CloudSelectionPage()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
