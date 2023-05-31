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

    public async void SeeConsolePage(System.Object sender, System.EventArgs e)
    {

        var selectedConsole = GameConsolesServices.gameConsoles
               .Where(x => x.SystemName == "PlayStation 2")
			   ;
		foreach (var item in selectedConsole)
		{
			Application.Current.MainPage = new NavigationPage(new GameConsolePage(item));
		}
        
    }

    public async void SeeTestPage(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new TestPage());
    public async void GetArcadeSelection(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new ArcadeSelectionPage());
}