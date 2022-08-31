using DrinkWater.ViewModels;

namespace DrinkWater.Views;

public partial class InfoView : ContentPage
{
	public InfoView(InfoViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}