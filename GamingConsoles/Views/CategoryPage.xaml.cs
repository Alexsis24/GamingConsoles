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
}