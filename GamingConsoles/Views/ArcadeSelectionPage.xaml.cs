namespace GamingConsoles.Views;

public partial class ArcadeSelectionPage : ContentPage
{
    public ArcadeSelectionPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        arcadeConsoles.ItemsSource = GameConsolesServices.GetArcadeConsoles();
    }
    
    public async void SeeCategories_Clicked(System.Object sender, System.EventArgs e)
        => Navigation.PushAsync(new CategoryPage());
}