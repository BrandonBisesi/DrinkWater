using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkWater.Models
{
    public class WaterIntake
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Intake { get; set; }
        public DateTime dateTime { get; set; }

        public WaterIntake(int intake)
        {
            Intake = intake;
            dateTime = DateTime.Now;
        }
    }
}
