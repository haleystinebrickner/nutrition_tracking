using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public partial class MealRecording : Form
    {
        private List<UserModel> availableUsers = GlobalConfig.Connection.GetAllUsers();
        private List<CategoryModel> availableCategory = GlobalConfig.Connection.GetAllCategory();
        private List<IntakeModel> recordedMeals = new List<IntakeModel>();
        //private ITeamRequester callingForm;

        private UserModel currentUser;  // Store the current user
        private List<IntakeModel> intakeList;
        private List<MealsModel> mealList;  // List to store goals for the user

        // Constructor that accepts UserModel object
        public MealRecording(UserModel user)
        {
            InitializeComponent();
            this.currentUser = user;
            WireUp();
            WireUp2();

            // Initialize the goal list for the user
            intakeList = new List<IntakeModel>();
        }



        private bool ValidateForm()
        {
            if (usermeal_combobox.Text.Length == 0)
            {
                return false;
            }
            if (categorymeal_combobox.Text.Length == 0)
            {
                return false;
            }
            if (amountmeal_textbox.Text.Length == 0)
            {
                return false;
            }
            return true;

        }


        private void usermeal_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recordmeal_button_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //create a PersonModel and fill all the data
                //save PersonModel back to database
                //clean all the fields
                MealsModel p = new MealsModel(categorymeal_combobox.Text, amountmeal_textbox.Text);
                p.Category = categorymeal_combobox.Text;
                p.MealValue = amountmeal_textbox.Text;
                p.User = usermeal_combobox.Text;


                p = GlobalConfig.Connection.CreateMeals(p); //this p has ID from database, unlike other p

                // add new member into listbox

                recordedmeals_listbox.Items.Add(p); 

                // Set property to display in the ListBox
                recordedmeals_listbox.DisplayMember = "Category"; 
                recordedmeals_listbox.ValueMember = "Id";

                //recordedmeals_listbox.Items.Add(categorymeal_combobox.Text);
                //recordedmeals_listbox.ValueMember = "Id";


                MessageBox.Show("Meal Recorded Successfully!");

                WireUp();

                categorymeal_combobox.Text = "";
                amountmeal_textbox.Text = "";

            }
            else
            {
                MessageBox.Show("Please fill in all of the fields");
            }

        }
        private void WireUp()
        {
            // Clear  data from the ComboBox
            usermeal_combobox.DataSource = null;


            // Retrieve users from the database
            var users = GlobalConfig.Connection.GetAllUsers();


            // Set the DataSource to the list of users
            usermeal_combobox.DataSource = users;


            // Set what property to display in the ComboBox
            usermeal_combobox.DisplayMember = "FullName";  // Display FullName in the ComboBox
            usermeal_combobox.ValueMember = "Id";  // Set the underlying value of the ComboBox to the user's Id

        }

        private void WireUp2()
        {
            PopulateCategoryComboBox();

        }

        private void PopulateCategoryComboBox()
        {
            // Retrieve categories from the database using GlobalConfig.Connection

            List<CategoryModel> categoriesList = GlobalConfig.Connection.GetAllCategory();

            categorymeal_combobox.Items.Clear();

            categorymeal_combobox.DataSource = categoriesList;
            categorymeal_combobox.DisplayMember = "Category";


        }
        private void see_percent_button_Click(object sender, EventArgs e)
        {
            SummaryForm frm = new SummaryForm();
            //DailyPercentagesForm frm = new (); //record_meals_listbox
            frm.Show();


        }

        private void deletemeal_button_Click(object sender, EventArgs e)
        {
            MealsModel selectedMeal = (MealsModel)recordedmeals_listbox.SelectedItem;

            int mealId = selectedMeal.Id;

            int rows = GlobalConfig.Connection.RemoveMeal(mealId);

            recordedmeals_listbox.Items.Remove(selectedMeal);

            MessageBox.Show("Meal removed successfully!");

           
        }
    }
}


