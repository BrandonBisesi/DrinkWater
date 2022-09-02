using DrinkWater.Views;

namespace DrinkWater;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(HistoryView), typeof(HistoryView));
        Routing.RegisterRoute(nameof(UserView), typeof(UserView));
    }
}
