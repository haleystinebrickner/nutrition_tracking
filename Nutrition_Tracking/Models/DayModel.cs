using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class DayModel
    {
        /// <summary>
        /// Represents the unique identifier of the day 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Used to distingush this tournament from others
        /// such as Pingpong tournament, Basketball tournament
        /// </summary>
        public string DayName { get; set; }


        /// <summary>
        /// Represents all of the intake in a day
        /// </summary>
        public List<IntakeModel> EnterIntake { get; set; } = new List<IntakeModel>();

        /// <summary>
        /// Represents all of the goals in a day
        /// </summary>
        public List<GoalModel> EnterGoal { get; set; } = new List<GoalModel>();

        /// <summary>
        /// Represents all of the meals in a day
        /// </summary>
        public List<MealsModel> EnterMeal { get; set; }= new List<MealsModel>();
    }
}
