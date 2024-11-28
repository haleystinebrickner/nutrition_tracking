using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrackerLibrary.Models
{
    public class MealsModel
    {


        /// <summary>
        /// Respresents the unique identifier of a meal
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Represents User Name
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Represents Category Name
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Represents Goal Value
        /// </summary>
        public string MealValue { get; set; }

        // This property will hold multiple goals if needed
        public List<MealsModel> EnterMeal { get; set; }
        //public object IntakeCategory { get; internal set; }
        public List<IntakeModel> IntakeCategory { get; set; }
        public List<GoalModel> GoalCategory { get; set; }

        /// <summary>
        /// Used to distingush this user meals from others.
        /// </summary>


        public MealsModel(string categoryName, string mealValueString)
        {
            Category = categoryName;
            int mealValueNumber = 0;
            int.TryParse(mealValueString, out mealValueNumber);
            int MealValue = mealValueNumber;

            // list to hold multiple meals
            EnterMeal = new List<MealsModel>();
        }
    }
}
