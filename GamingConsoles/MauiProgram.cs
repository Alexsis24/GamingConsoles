namespace GamingConsoles;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("EvilEmpire-4BBVK.ttf", "TitleFont");
				fonts.AddFont("Niagaraphobia-Bro3.ttf", "SubTitleFont");
				fonts.AddFont("TrulyMadlyDpad-a72o.ttf", "TextFont");
				fonts.AddFont("super-mario-bros-nes.ttf", "RetroFont");
			});

		return builder.Build();
	}
}
