using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using TrackerLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrackerLibrary
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
            WireUp();
        }




        private void percentage_button_Click(object sender, EventArgs e)
        {
            //for selected category, link to percentage form with category selected in drop down
            string selectedCategory = percentage_button.Text;

            var percentageForm = new DailyPercentagesForm(); 
            percentageForm.ShowDialog();
        }

        


        

        private void add_selected_button_Click(object sender, EventArgs e)
        {
            //add selected category to list box
            string selectedCategory = category1_combobox.Text;

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Please select a category to add.");
                return;
            }

            // Add the category to the ListBox if it's not already there
            if (!usersummary_listbox.Items.Contains(selectedCategory))
            {
                usersummary_listbox.Items.Add(selectedCategory);
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            //remove selected category from list box
            string selectedCategory = usersummary_listbox.SelectedItem?.ToString();
            usersummary_listbox.Items.Remove(selectedCategory);

        }

        private void WireUp()
        {
            // Clear existing data from the ComboBox
            usersummary_combobox.DataSource = null;
            category1_combobox.DataSource = null;

            // Retrieve the list of users from the database
            var users = GlobalConfig.Connection.GetAllUsers();
            var categories = GlobalConfig.Connection.GetAllCategory();

            // Set the DataSource to the list of users
            usersummary_combobox.DataSource = users;
            category1_combobox.DataSource = categories;

            // Set what property to display in the ComboBox
            usersummary_combobox.DisplayMember = "FullName";  // Display FullName in the ComboBox
            usersummary_combobox.ValueMember = "Id";  // Set the underlying value of the ComboBox to the user's Id

            category1_combobox.DisplayMember = "Category";
            category1_combobox.ValueMember = "Id";


        }
        
        private void getsummary2_button_Click(object sender, EventArgs e)
        {
            string categoryName = category1_combobox.Text.ToString();

            try
            {
                // Get the goal and intake for the selected category
                var categorySummary = GlobalConfig.Connection.GetGoalAndIntakeByCategory(categoryName);

                // Display total intake information
                MessageBox.Show($"Summary for {categoryName}" + Environment.NewLine +
                    $"Daily Goal: {categorySummary.Goal}" + Environment.NewLine+
                    $"Total Intake: {categorySummary.TotalIntake}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }





    }


}
