using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public UserModel CreateUser(UserModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spUser_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }
        public GoalModel CreateGoal(GoalModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                var p = new DynamicParameters();
                p.Add("@User", model.User);
                p.Add("@Category", model.Name);
                p.Add("@Value", model.GoalValue);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spGoal_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }

        public IntakeModel CreateIntake(IntakeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                var p = new DynamicParameters();
                p.Add("@User", model.User);
                p.Add("@Category", model.Name);
                p.Add("@Value", model.ConsumedValue);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spIntake_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }

        public MealsModel CreateMeals(MealsModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                var p = new DynamicParameters();
                p.Add("@User", model.User);
                //p.Add("@GoalCategory", model.Name);
                //p.Add("@GoalAmount", model.MealValue);
                p.Add("@Category", model.Category);
                p.Add("@Value", model.MealValue);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spIntake_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }
        

        public CategoryModel CreateCategory(CategoryModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@UserName", model.User);
                p.Add("@UserId", model.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spCategory_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;

            }
        }

        public List<CategoryModel> GetAllCategory()
        {
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                
                return connection.Query<CategoryModel>("spGetAllCategories", commandType: CommandType.StoredProcedure).ToList();
            }
        }


        public List<UserModel> GetAllUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                
                var users = connection.Query<UserModel>("spGetAllUsers", commandType: CommandType.StoredProcedure).ToList();
                return users;
            }

            TotalsModel CreateTotals(TotalsModel model)
            {
                throw new NotImplementedException();
            }

            List<IntakeModel> GetIntake_All()
            {
                throw new NotImplementedException();
            }


        }
        

        public CategorySummaryModel GetGoalAndIntakeByCategory(string categoryName)
        {
            var summary = new CategorySummaryModel();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                
                var goalParameters = new { CategoryName = categoryName };

                var goalResult = connection.Query<double>("spGetGoalsByCategory", goalParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                
                summary.Goal = goalResult != 0 ? goalResult : 0;

                var intakeParameters = new { CategoryName = categoryName };
                double totalIntake = connection.ExecuteScalar<double>(
                    "spGetIntakeByCategory2",
                    intakeParameters,
                    commandType: CommandType.StoredProcedure
                );

                summary.TotalIntake = totalIntake;
            }

            return summary;
        }

        public static void ClearDatabase()
        {
            using (var connection = new SqlConnection(GlobalConfig.CnnString("NutritionDB")))
            {
                connection.Open();

                var transaction = connection.BeginTransaction();
                try
                {
                    // clear table values
                    connection.Execute("DELETE FROM Goals", transaction: transaction);
                    connection.Execute("DELETE FROM Intake", transaction: transaction);
                    connection.Execute("DELETE FROM Users", transaction: transaction);
                    connection.Execute("DELETE FROM Category", transaction:transaction);
                    

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    
                }
            }
        }

        public int RemoveMeal(int Id)
        {
            // Define the connection string (you might want to use a configuration file)
            string connectionString = GlobalConfig.CnnString("NutritionDB");
            int rowsAffected = 0;

            // Establish a connection to the database
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var parameters = new { id = Id };  // Passing the MealId to the stored procedure

                // Execute the stored procedure to remove the meal
                rowsAffected = connection.Execute("sp_RemoveIntake", parameters, commandType: CommandType.StoredProcedure);
            }
            return rowsAffected;
        }
        
    
        TotalsModel IDataConnection.CreateTotals(TotalsModel model)
        {
            throw new NotImplementedException();
        }

        
    }
}
