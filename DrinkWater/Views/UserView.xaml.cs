using DrinkWater.ViewModels;

namespace DrinkWater.Views;

public partial class UserView : ContentPage
{
	public UserView(UserViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}