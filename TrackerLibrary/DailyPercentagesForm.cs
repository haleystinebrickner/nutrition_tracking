using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public partial class DailyPercentagesForm : Form
    {
        private List<CategoryModel> availableCategory = GlobalConfig.Connection.GetAllCategory();
        public DailyPercentagesForm()
        {
            InitializeComponent();
            WireUp();
        }

       
        private void WireUp()
        {
            category_percent_dropdown.DataSource = null;
            category_percent_dropdown.DataSource = availableCategory;
            category_percent_dropdown.DisplayMember = "Category";
        }

       
        private void ProgressButton_Click(object sender, EventArgs e)
        {
            string categoryName = category_percent_dropdown.Text.ToString();

            var categorySummary = GlobalConfig.Connection.GetGoalAndIntakeByCategory(categoryName);

            double goalval = categorySummary.Goal;
            double intakeval = categorySummary.TotalIntake;

            double percentage = (intakeval / goalval) * 100;
            string custom = "";

            if (percentage > 100)
            {
                custom = "Amazing job! You exceeded your goal!";
            }
            else if (percentage == 100)
            {
                custom = "Good job! You met your goal.";
            }
            else
            {
                custom = "You did not meet your goal.";
            }

            MessageBox.Show($"{percentage}%" + Environment.NewLine + $"{custom}");
        }

        private void seemore_button_Click(object sender, EventArgs e)
        {
            category_percent_dropdown.Text = "";
        }

        private void firstname_label_Click(object sender, EventArgs e)
        {

        }
    }
}
