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

	async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	{
		await Navigation.PushAsync(new TestPage());
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

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