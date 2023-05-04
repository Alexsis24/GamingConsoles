namespace GamingConsoles.Views;

public partial class LaunchPage : ContentPage
{

	public LaunchPage()
	{
		InitializeComponent();
	}
    async void SeeConsoles_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new CategoryPage());
}