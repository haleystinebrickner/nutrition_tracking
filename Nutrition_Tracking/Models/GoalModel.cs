using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    public class GoalModel
    {
        /// <summary>
        /// Represents goal ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents User Name
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Represents Category Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents Goal Value
        /// </summary>
        public string GoalValue { get; set; }

        // This property will hold multiple goals if needed
        public List<GoalModel> EnterGoal { get; set; }

        public GoalModel(){}

        //initialize the GoalModel with category and goal value
        public GoalModel(string categoryName, string goalValueString)
        {
            Name = categoryName;
            int goalValueNumber = 0;
            int.TryParse(goalValueString, out goalValueNumber); 
            double GoalValue = goalValueNumber;

            // list to hold multiple goals
            EnterGoal = new List<GoalModel>();
        }



    }
}