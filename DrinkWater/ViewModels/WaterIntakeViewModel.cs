using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DrinkWater.Models;
using DrinkWater.Services;

namespace DrinkWater.ViewModels
{
    public partial class WaterIntakeViewModel : ObservableObject
    {
        [ObservableProperty]
        public int amount;

        [RelayCommand]
        public void AddWater()
        {
            DrinkWaterService.AddWater(Amount);
        }

    }
}
