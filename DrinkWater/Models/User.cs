using SQLite;
namespace DrinkWater.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public double RecommendedWaterIntake { get; set; }

        public User()
        {

        }

        public User(int id, string name, string age, string weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Weight = weight;
            RecommendedWaterIntake = CalculateRecommendedWaterIntake();
        }

        public void Clear()
        {
            Name = string.Empty;
            Weight = string.Empty;
            RecommendedWaterIntake = 0;
        }

        public double CalculateRecommendedWaterIntake()
        {
            double value;
            int age;
            if(Double.TryParse(this.Weight, out value) && Int32.TryParse(this.Age, out age))
            {
                double a = value / 2.2;
                double b;
                switch (age)
                {
                    case > 55:
                        b = 40;
                        break;
                    case > 30:
                        b = 35;
                        break;
                    default:
                        b = 40;
                        break;     
                }
                double resultInMils = (((a * b) / 28.3) / 33.8) * 1000;

                return Math.Round(resultInMils);
            }
            else
            {
                return 0;
            }
        }

    }
}
