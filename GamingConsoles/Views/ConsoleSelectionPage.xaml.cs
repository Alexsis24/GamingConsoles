namespace GamingConsoles.Views;

public partial class ConsoleSelectionPage : ContentPage
{

    public ConsoleSelectionPage(Category category)
	{
		InitializeComponent();
		this.BindingContext = category;
	}

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
//https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-7.0