namespace GamingConsoles.Views;

public partial class VRSelectionPage : ContentPage
{
	public VRSelectionPage()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
