using GamingConsoles.Services;

namespace GamingConsoles.Views;

public partial class CategoryPage : ContentPage
{
	public CategoryPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();	

	}

	public async void GetHomeSelection(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new HomeSelectionPage());
    }
    public async void GetHandheldSelection(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new HandheldSelectionPage());
    }
    public async void GetVRSelection(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new VRSelectionPage());
    }
    async void GetArcadeSelection(System.Object sender, System.EventArgs e)
	{
		await Navigation.PushAsync(new ArcadeSelectionPage());
	}
    public async void GetCloudSelection(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new CloudSelectionPage());
    }

    
}