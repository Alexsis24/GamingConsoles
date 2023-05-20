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


	public async void GetHomeSelection(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new HomeSelectionPage());
    public async void GetHandheldSelection(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new HandheldSelectionPage());
    public async void GetVRSelection(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new VRSelectionPage());
    public async void GetArcadeSelection(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new ArcadeSelectionPage());
    public async void GetCloudSelection(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new CloudSelectionPage());

}