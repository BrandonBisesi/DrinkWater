using DrinkWater.Views;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DrinkWater.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        async Task Info()
        {
            await Shell.Current.GoToAsync(nameof(InfoView));
        }

        [RelayCommand]
        async Task History()
        {
            await Shell.Current.GoToAsync(nameof(HistoryView));
        }
    }
}
