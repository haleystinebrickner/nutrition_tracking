using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using TrackerLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrackerLibrary
{
    public partial class CreateUserForm : Form
    {
        private Form callingForm;

        public CreateUserForm()
        {
            
            InitializeComponent();

            
        }


        private void createuser_button_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //create a PersonModel and fill all the data
                //save PersonModel back to database
                //clean all the fields
                UserModel u = new UserModel();
                u.FirstName = firstname_textbox.Text;
                u.LastName = lastname_textbox.Text;
                u.EmailAddress = email_textbox.Text;
                u.PhoneNumber = phonenumber_textbox.Text;

                u = GlobalConfig.Connection.CreateUser(u); //this u has ID from database, unlike other u


                firstname_textbox.Text = "";
                lastname_textbox.Text = "";
                email_textbox.Text = "";
                phonenumber_textbox.Text = "";

                goals_form goalsForm = new goals_form(u);
                goalsForm.Show();
            }
            else
            {
                MessageBox.Show("Please fill in all of the fields");
            }

          
            
        }
        private bool ValidateForm()
        {
            if (firstname_label.Text.Length == 0)
            {
                return false;
            }
            if (lastname_label.Text.Length == 0) { return false; }
            if (email_label.Text.Length == 0) { return false; }
            if (phonenumber_label.Text.Length == 0) { return false; }
            return true;
        }


        private void usersummary_label_Click(object sender, EventArgs e)
        {

        }

        private void phonenumber_label_Click(object sender, EventArgs e)
        {

        }
    }
    
}
