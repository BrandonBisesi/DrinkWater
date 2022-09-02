﻿using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using DrinkWater.Models;
using DrinkWater.Services;
//using ReactiveUI;
using System.ComponentModel;
//using ReactiveUI.Fody.Helpers;
//using MvvmHelpers;

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
            DrinkWaterService.UpdateUser(user, name, weight, age);
            Refresh();
        }

        public User GetUser()
        {
            return DrinkWaterService.GetUser();
        }

        public void Refresh()
        {
            if (User != null)
                User.Clear();
            User = GetUser();
        }
    }
}