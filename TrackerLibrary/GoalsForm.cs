using System.Diagnostics.Metrics;
using System;
using System.Reflection;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using TrackerLibrary.Models;
using static System.Windows.Forms.LinkLabel;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{

    public partial class goals_form : Form
    {
        private UserModel currentUser;  
        private List<GoalModel> goalList;  

        
        public goals_form(UserModel user)
        {
            InitializeComponent();
            currentUser = user;
            WireUp();

            
            goalList = new List<GoalModel>();

        }

        
        private void setgoal_button_Click(object sender, EventArgs e)
        {
            if (ValidateForm2())
            {
                //create a PersonModel and fill all the data
                //save PersonModel back to database
                //clean all the fields
                GoalModel p = new GoalModel(category_combobox.Text, amount_textbox.Text);
                p.Name = category_combobox.Text;
                p.GoalValue = amount_textbox.Text;
                p.User = user_combobox.Text;


                p = GlobalConfig.Connection.CreateGoal(p); //this p has ID from database, unlike other p


                goalList.Add(p);

                MessageBox.Show("Goal set successfully!");

                WireUp();

                category_combobox.Text = "";
                amount_textbox.Text = "";

            }
            else
            {
                MessageBox.Show("Please fill in all of the fields");
            }


            
        }

      


        private void addcategory_button_Click(object sender, EventArgs e)
        {
            // Validate the form to ensure the category input is not empty
            
            // Create a new CategoryModel and fill its data
            CategoryModel c = new CategoryModel();
            c.Name = category_textbox.Text;

            // Save the category to the database and get the updated CategoryModel 
            c = GlobalConfig.Connection.CreateCategory(c); //  now has an ID from the database

            // Add the category to the ComboBox
            
            category_combobox.Items.Add(c);
            category_combobox.SelectedItem = c;


            WireUp();

            category_textbox.Text = "";
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createnewuser_button_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.ShowDialog();
        }

        private void or_label_Click(object sender, EventArgs e)
        {

        }



        private void WireUp()
        {
            // Clear existing data 
            user_combobox.DataSource = null;

            // Retrieve the list of users from the database
            var users = GlobalConfig.Connection.GetAllUsers();

            // Set the DataSource to the list of users
            user_combobox.DataSource = users;

            // Set what property to display in  ComboBox
            user_combobox.DisplayMember = "FullName";  // Display FullName in the ComboBox
            user_combobox.ValueMember = "Id";  // Set value of the ComboBox to the user's Id
        }

    

        private bool ValidateForm()
        {
            if (category_textbox.Text.Length == 0)
            {
                return false;
            }
            else return true;

        }
        private bool ValidateForm2()
        {
            if (user_combobox.Text.Length == 0)
            {
                return false;
            }
            if (category_combobox.Text.Length == 0)
            {
                return false;
            }
            if (amount_textbox.Text.Length == 0)
            {
                return false;
            }
            return true;

        }


        private void user_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
            currentUser = (UserModel) user_combobox.SelectedItem;
            
        }

        private void category_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show all categorys in the dropdown
            //retrieve from DB
            // Check if an item is selected
            if (category_combobox.SelectedItem != null)
            {
                // Get the selected CategoryModel object
                CategoryModel selectedCategory = (CategoryModel)category_combobox.SelectedItem;

                MessageBox.Show($"You selected: {selectedCategory.Name}");
            }
        }

        private void PopulateCategoryComboBox()
        {
            // Retrieve categories from the database 
            var sqlConnector = new SqlConnector();

            var categories = sqlConnector.GetAllCategory();


            // Clear any existing items
            category_combobox.Items.Clear();

            // Add the categories to the ComboBox
            foreach (var category in categories)
            {
                category_combobox.Items.Add(category);
            }

            // select the first item in the ComboBox
            if (category_combobox.Items.Count > 0)
            {
                category_combobox.SelectedIndex = 0;
            }
        }


       

        private void finished_button_Click(object sender, EventArgs e)
        {
            
                // Get the selected UserModel object from the combo box (not just the text)
                UserModel selectedUser = user_combobox.SelectedItem as UserModel;

                if (selectedUser != null)
                {
                    // Pass UserModel object to the MealRecording form
                    MealRecording frm = new MealRecording(selectedUser); 
                    frm.Show();
                }
                else
                {
                    // Handle  invalid data
                    MessageBox.Show("Please select a user.");
                }
            }


        }
    }


        
    

