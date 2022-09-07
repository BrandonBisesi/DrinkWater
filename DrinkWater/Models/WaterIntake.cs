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
        public DateTime DateTime { get; set; }

        public WaterIntake()
        {

        }

        public WaterIntake(int intake)
        {
            Intake = intake;
            DateTime = DateTime.Now;
        }
    }
}
