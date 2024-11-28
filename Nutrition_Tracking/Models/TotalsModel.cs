using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.Models
{
    public class TotalsModel
    {
        public int GoalId { get; set; }
        public string GoalName { get; set; }
        public List<UserModel> Users { get; set; }

        /// <summary>
        /// Dictionary to hold category names and total consumed values
        /// </summary>
        public Dictionary<string, double> TotalConsumedByCategory { get; private set; }

        /// <summary>
        /// Dictionary to hold category names and percentage consumed values
        /// </summary>
        public Dictionary<string, double> PercentageConsumedByCategory { get; private set; }

        /// <summary>
        /// Constructor that initializes dictionaries and performs calculations.
        /// </summary>
        public TotalsModel()
        {
            TotalConsumedByCategory = new Dictionary<string, double>();
            PercentageConsumedByCategory = new Dictionary<string, double>();
        }

        /// <summary>
        /// Calculates the total intake values for each category.
        /// </summary>
        public void CalculateTotals(List<MealsModel> meals)
        {
            TotalIntake(meals);
            CalculatePercentageOfGoals(meals);
        }

        /// <summary>
        /// Calculates total consumed values for each category from the meals list.
        /// </summary>
        private void TotalIntake(List<MealsModel> meals)
        {
            foreach (var meal in meals)
            {
                foreach (var intake in meal.IntakeCategory) // Assuming IntakeCategory is a list of IntakeModel
                {
                    if (TotalConsumedByCategory.ContainsKey(intake.Name))
                    {
                        TotalConsumedByCategory[intake.Name] += intake.ConsumedValue;
                    }
                    else
                    {
                        TotalConsumedByCategory[intake.Name] = intake.ConsumedValue;
                    }
                }
            }
        }

        /// <summary>
        /// Calculates the percentage of the goal consumed for each category.
        /// </summary>
        private void CalculatePercentageOfGoals(List<MealsModel> meals)
        {
            foreach (var category in TotalConsumedByCategory.Keys)
            {
                double totalConsumed = TotalConsumedByCategory[category];

                // Get the goal value for the category (assumes GoalCategory is a list of GoalModel)
                var goal = meals.SelectMany(m => m.GoalCategory)  // Flatten GoalCategory across all meals
                                .FirstOrDefault(g => g.Name == category)?.GoalValue;
                int goalint = 0;
                int.TryParse(goal, out goalint);

                if (goalint !=0 && goalint > 0) // Ensure goal is not null or zero
                {
                    double percentage = (totalConsumed / goalint) * 100;
                    PercentageConsumedByCategory[category] = percentage;
                }
                else
                {
                    PercentageConsumedByCategory[category] = 0; // If no valid goal, set percentage to 0
                }
            }
        }
    }
}
