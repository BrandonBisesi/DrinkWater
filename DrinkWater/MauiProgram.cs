using DrinkWater.ViewModels;
using DrinkWater.Views;

namespace DrinkWater;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MainView>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<InfoView>();
        builder.Services.AddSingleton<InfoViewModel>();
        builder.Services.AddSingleton<HistoryView>();
        builder.Services.AddSingleton<HistoryViewModel>();

        return builder.Build();
	}
}
