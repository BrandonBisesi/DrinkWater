using DrinkWater.Models;
using SQLite;
using System;

namespace DrinkWater.Services
{
    public static class DrinkWaterService
    {
        static SQLiteConnection db;
        static void Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");
            db = new SQLiteConnection(databasePath);

            db.CreateTable<User>();
        }

        public static User AddUser(string name, string weight, string age)
        {
            Init();
            var user = new User(1, name, weight, age);

            db.Insert(user);
            return user;
        }

        public static void UpdateUser(User user, string name, string weight, string age)
        {
            Init();
            if (user == null)
            {
                user = AddUser(name, weight, age);
            }

            user.Name = name;
            user.Weight = weight;
            user.Age = age;
            user.RecommendedWaterIntake = user.CalculateRecommendedWaterIntake();

            db.Update(user);
        }

        public static User GetUser()
        {
            Init();
            var user = db.Table<User>().First();
            return user;
        }
    }
}
