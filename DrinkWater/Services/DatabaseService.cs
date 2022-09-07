using DrinkWater.Models;
using SQLite;
using System;
using System.Collections.ObjectModel;

namespace DrinkWater.Services
{
    public static class DatabaseService
    {
        static SQLiteConnection db;
        static void Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");
            db = new SQLiteConnection(databasePath);

            db.CreateTable<User>();
            db.CreateTable<WaterIntake>();
        }

        #region User Functions
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
            var user = db.Table<User>().FirstOrDefault();
            return user;
        }
        #endregion

        #region WaterIntake Functions

        public static int AddWater(int intake)
        {
            Init();
            var waterIntake = new WaterIntake(intake);

            db.Insert(waterIntake);
            return waterIntake.Id;
        }

        public static IList<WaterIntake> GetWaterIntakes()
        {
            Init();
            IList<WaterIntake> list = db.Table<WaterIntake>().ToList();
            return list;
        }

        #endregion
    }
}
