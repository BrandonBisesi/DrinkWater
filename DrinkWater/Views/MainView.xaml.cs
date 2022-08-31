using DrinkWater.ViewModels;

namespace DrinkWater.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}