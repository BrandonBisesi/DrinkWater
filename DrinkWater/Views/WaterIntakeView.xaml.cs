using DrinkWater.ViewModels;

namespace DrinkWater.Views;

public partial class WaterIntakeView : ContentPage
{
	public WaterIntakeView(WaterIntakeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}