using DrinkWater.Views;
using CommunityToolkit.Mvvm.Input;

namespace DrinkWater.ViewModels
{
    public partial class MainViewModel : BindableObject
    {
        [RelayCommand]
        async Task Info()
        {
            await Shell.Current.GoToAsync(nameof(UserView));
        }

        [RelayCommand]
        async Task History()
        {
            await Shell.Current.GoToAsync(nameof(HistoryView));
        }

        [RelayCommand]
        async Task WaterIntake()
        {
            await Shell.Current.GoToAsync(nameof(WaterIntakeView));
        }

    }
}
