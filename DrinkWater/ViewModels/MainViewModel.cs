using DrinkWater.Views;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using DrinkWater.Services;

namespace DrinkWater.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public double progress;

        public MainViewModel()
        {
            UpdateProgress();
        }

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

        [RelayCommand]
        public void UpdateProgress()
        {
            var intake = DatabaseService.GetWaterIntakes()
                            .Where(x => x.DateTime.Date == DateTime.Today.Date)
                            .Select(x => x.Intake);

            int dailyIntake = 0;

            foreach (var i in intake)
            {
                dailyIntake += i;
            }

            var user = DatabaseService.GetUser();
            if (user != null)
            {
                var recommendedIntake = user.RecommendedWaterIntake;

                Progress = dailyIntake / recommendedIntake;
            }
            else
            {
                Progress = 0;
            }
        }

    }
}
