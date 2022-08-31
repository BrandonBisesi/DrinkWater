using DrinkWater.ViewModels;

namespace DrinkWater.Views;

public partial class HistoryView : ContentPage
{
	public HistoryView(HistoryViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}