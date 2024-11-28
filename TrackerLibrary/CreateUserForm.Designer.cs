namespace TrackerLibrary
{
    partial class CreateUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstname_label = new Label();
            lastname_label = new Label();
            email_label = new Label();
            phonenumber_label = new Label();
            firstname_textbox = new TextBox();
            lastname_textbox = new TextBox();
            email_textbox = new TextBox();
            phonenumber_textbox = new TextBox();
            createuser_button = new Button();
            SuspendLayout();
            // 
            // firstname_label
            // 
            firstname_label.AutoSize = true;
            firstname_label.BackColor = Color.White;
            firstname_label.ForeColor = SystemColors.Desktop;
            firstname_label.Location = new Point(27, 52);
            firstname_label.Name = "firstname_label";
            firstname_label.Size = new Size(101, 25);
            firstname_label.TabIndex = 13;
            firstname_label.Text = "First Name:";
            firstname_label.Click += usersummary_label_Click;
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.BackColor = Color.White;
            lastname_label.ForeColor = SystemColors.Desktop;
            lastname_label.Location = new Point(27, 107);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(99, 25);
            lastname_label.TabIndex = 14;
            lastname_label.Text = "Last Name:";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.BackColor = Color.White;
            email_label.ForeColor = SystemColors.Desktop;
            email_label.Location = new Point(27, 163);
            email_label.Name = "email_label";
            email_label.Size = new Size(58, 25);
            email_label.TabIndex = 15;
            email_label.Text = "Email:";
            // 
            // phonenumber_label
            // 
            phonenumber_label.AutoSize = true;
            phonenumber_label.BackColor = Color.White;
            phonenumber_label.ForeColor = SystemColors.Desktop;
            phonenumber_label.Location = new Point(27, 218);
            phonenumber_label.Name = "phonenumber_label";
            phonenumber_label.Size = new Size(66, 25);
            phonenumber_label.TabIndex = 16;
            phonenumber_label.Text = "Phone:";
            phonenumber_label.Click += phonenumber_label_Click;
            // 
            // firstname_textbox
            // 
            firstname_textbox.Location = new Point(132, 52);
            firstname_textbox.Name = "firstname_textbox";
            firstname_textbox.Size = new Size(186, 31);
            firstname_textbox.TabIndex = 17;
            // 
            // lastname_textbox
            // 
            lastname_textbox.Location = new Point(132, 107);
            lastname_textbox.Name = "lastname_textbox";
            lastname_textbox.Size = new Size(188, 31);
            lastname_textbox.TabIndex = 18;
            // 
            // email_textbox
            // 
            email_textbox.Location = new Point(132, 163);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(188, 31);
            email_textbox.TabIndex = 19;
            // 
            // phonenumber_textbox
            // 
            phonenumber_textbox.Location = new Point(132, 218);
            phonenumber_textbox.Name = "phonenumber_textbox";
            phonenumber_textbox.Size = new Size(186, 31);
            phonenumber_textbox.TabIndex = 20;
            // 
            // createuser_button
            // 
            createuser_button.Location = new Point(112, 280);
            createuser_button.Name = "createuser_button";
            createuser_button.Size = new Size(112, 34);
            createuser_button.TabIndex = 21;
            createuser_button.Text = "Create User";
            createuser_button.UseVisualStyleBackColor = true;
            createuser_button.Click += createuser_button_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(372, 354);
            Controls.Add(createuser_button);
            Controls.Add(phonenumber_textbox);
            Controls.Add(email_textbox);
            Controls.Add(lastname_textbox);
            Controls.Add(firstname_textbox);
            Controls.Add(phonenumber_label);
            Controls.Add(email_label);
            Controls.Add(lastname_label);
            Controls.Add(firstname_label);
            ForeColor = SystemColors.Desktop;
            Name = "CreateUserForm";
            Text = "Create User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstname_label;
        private Label lastname_label;
        private Label email_label;
        private Label phonenumber_label;
        private TextBox firstname_textbox;
        private TextBox lastname_textbox;
        private TextBox email_textbox;
        private TextBox phonenumber_textbox;
        private Button createuser_button;
    }
}