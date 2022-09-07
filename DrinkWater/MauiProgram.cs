using DrinkWater.ViewModels;
using DrinkWater.Views;
using CommunityToolkit.Maui;

namespace DrinkWater;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MainView>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddTransient<UserView>();
        builder.Services.AddTransient<UserViewModel>();

        builder.Services.AddTransient<WaterIntakeView>();
        builder.Services.AddTransient<WaterIntakeViewModel>();

        builder.Services.AddTransient<HistoryView>();
        builder.Services.AddTransient<HistoryViewModel>();

        return builder.Build();
	}
}
