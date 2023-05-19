namespace GamingConsoles.Views;

public partial class HandheldSelectionPage : ContentPage
{
	public HandheldSelectionPage()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
