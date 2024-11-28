using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        CategoryModel CreateCategory(CategoryModel c);
        GoalModel CreateGoal(GoalModel model);

        IntakeModel CreateIntake(IntakeModel model);

        MealsModel CreateMeals(MealsModel model);

        TotalsModel CreateTotals(TotalsModel model);    

        UserModel CreateUser(UserModel model);
        List<CategoryModel> GetAllCategory();
        List<UserModel> GetAllUsers();
      
        CategorySummaryModel GetGoalAndIntakeByCategory(string categoryName);
        
        int RemoveMeal(int i);
    }
}
