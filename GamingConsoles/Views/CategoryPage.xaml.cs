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

	public async void SeeTestPage(System.Object sender, System.EventArgs e)
		=> Application.Current.MainPage = new NavigationPage(new GameConsolePage());
}