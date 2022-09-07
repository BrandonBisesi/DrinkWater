using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using DrinkWater.Models;
using DrinkWater.Services;

namespace DrinkWater.ViewModels
{
    public partial class UserViewModel : ObservableObject
    {
        [ObservableProperty]
        public User user;

        public UserViewModel()
        {
            Refresh();
        }


        [RelayCommand]
        public async void Update()
        {
            var name = await App.Current.MainPage.DisplayPromptAsync("Update Info", "Name");
            var weight = await App.Current.MainPage.DisplayPromptAsync("Update Info", "Weight in lbs");
            var age = await App.Current.MainPage.DisplayPromptAsync("Update Info", "Age");
            DatabaseService.UpdateUser(user, name, weight, age);
            Refresh();
        }

        public User GetUser()
        {
            return DatabaseService.GetUser();
        }

        public void Refresh()
        {
            if (User != null)
                User.Clear();
            User = GetUser();
        }
    }
}
