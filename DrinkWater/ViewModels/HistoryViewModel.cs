using CommunityToolkit.Mvvm.Input;
using DrinkWater.Models;
using DrinkWater.Services;
using MvvmHelpers;
using System.Collections.ObjectModel;
using System.Linq;

namespace DrinkWater.ViewModels
{
    public partial class HistoryViewModel : ObservableObject
    {
        public IEnumerable<Grouping<DateTime, WaterIntake>> source;

        public ObservableRangeCollection<Grouping<DateTime,WaterIntake>> IntakeList { get; set; }

        public HistoryViewModel()
        {
            GetWaterIntakeList();
            IntakeList = new ObservableRangeCollection<Grouping<DateTime, WaterIntake>>();
            IntakeList.ReplaceRange(source);
        }

        public void GetWaterIntakeList()
        {
            source = from intake in DatabaseService.GetWaterIntakes()
                     orderby intake.DateTime
                     group intake by intake.DateTime.Date into intakeGroup
                     select new Grouping<DateTime, WaterIntake>(intakeGroup.Key, intakeGroup);

            //source = DatabaseService.GetWaterIntakes()
            //         .Where(x => x.DateTime > DateTime.Today.AddDays(-7))
            //         .OrderBy(x => x.Intake)
            //         .GroupBy(x => x.DateTime);
        }
    }
}
