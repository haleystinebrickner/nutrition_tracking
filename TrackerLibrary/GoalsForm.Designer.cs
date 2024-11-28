namespace TrackerLibrary
{
    partial class goals_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            category_label = new Label();
            amount_textbox = new TextBox();
            category_combobox = new ComboBox();
            setgoal_button = new Button();
            amount_label = new Label();
            addnewcategory_groupbox = new GroupBox();
            addcategory_button = new Button();
            category_textbox = new TextBox();
            newcategory_label = new Label();
            user_label = new Label();
            user_combobox = new ComboBox();
            createnewuser_button = new Button();
            or_label = new Label();
            finished_button = new Button();
            addnewcategory_groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // category_label
            // 
            category_label.AutoSize = true;
            category_label.BackColor = Color.White;
            category_label.ForeColor = SystemColors.Desktop;
            category_label.Location = new Point(55, 152);
            category_label.Name = "category_label";
            category_label.Size = new Size(84, 25);
            category_label.TabIndex = 1;
            category_label.Text = "Category";
            // 
            // amount_textbox
            // 
            amount_textbox.BackColor = Color.White;
            amount_textbox.Location = new Point(193, 201);
            amount_textbox.Name = "amount_textbox";
            amount_textbox.Size = new Size(182, 31);
            amount_textbox.TabIndex = 2;
            // 
            // category_combobox
            // 
            category_combobox.BackColor = Color.White;
            category_combobox.FormattingEnabled = true;
            category_combobox.Location = new Point(193, 149);
            category_combobox.Name = "category_combobox";
            category_combobox.Size = new Size(182, 33);
            category_combobox.TabIndex = 4;
            category_combobox.SelectedIndexChanged += category_combobox_SelectedIndexChanged;
            // 
            // setgoal_button
            // 
            setgoal_button.ForeColor = SystemColors.Desktop;
            setgoal_button.Location = new Point(193, 250);
            setgoal_button.Name = "setgoal_button";
            setgoal_button.Size = new Size(112, 34);
            setgoal_button.TabIndex = 5;
            setgoal_button.Text = "Set Goal";
            setgoal_button.UseVisualStyleBackColor = true;
            setgoal_button.Click += setgoal_button_Click;
            // 
            // amount_label
            // 
            amount_label.AutoSize = true;
            amount_label.BackColor = Color.White;
            amount_label.ForeColor = SystemColors.Desktop;
            amount_label.Location = new Point(55, 207);
            amount_label.Name = "amount_label";
            amount_label.Size = new Size(77, 25);
            amount_label.TabIndex = 6;
            amount_label.Text = "Amount";
            // 
            // addnewcategory_groupbox
            // 
            addnewcategory_groupbox.Controls.Add(addcategory_button);
            addnewcategory_groupbox.Controls.Add(category_textbox);
            addnewcategory_groupbox.Controls.Add(newcategory_label);
            addnewcategory_groupbox.ForeColor = SystemColors.Desktop;
            addnewcategory_groupbox.Location = new Point(62, 309);
            addnewcategory_groupbox.Name = "addnewcategory_groupbox";
            addnewcategory_groupbox.Size = new Size(372, 169);
            addnewcategory_groupbox.TabIndex = 8;
            addnewcategory_groupbox.TabStop = false;
            addnewcategory_groupbox.Text = "Add New Category";
            // 
            // addcategory_button
            // 
            addcategory_button.Location = new Point(113, 120);
            addcategory_button.Name = "addcategory_button";
            addcategory_button.Size = new Size(112, 34);
            addcategory_button.TabIndex = 11;
            addcategory_button.Text = "Add";
            addcategory_button.UseVisualStyleBackColor = true;
            addcategory_button.Click += addcategory_button_Click;
            // 
            // category_textbox
            // 
            category_textbox.Location = new Point(145, 61);
            category_textbox.Name = "category_textbox";
            category_textbox.Size = new Size(221, 31);
            category_textbox.TabIndex = 10;
            // 
            // newcategory_label
            // 
            newcategory_label.AutoSize = true;
            newcategory_label.BackColor = Color.White;
            newcategory_label.ForeColor = SystemColors.Desktop;
            newcategory_label.Location = new Point(6, 61);
            newcategory_label.Name = "newcategory_label";
            newcategory_label.Size = new Size(124, 25);
            newcategory_label.TabIndex = 9;
            newcategory_label.Text = "New Category";
            newcategory_label.Click += label1_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.BackColor = Color.White;
            user_label.ForeColor = SystemColors.Desktop;
            user_label.Location = new Point(62, 31);
            user_label.Name = "user_label";
            user_label.Size = new Size(98, 25);
            user_label.TabIndex = 9;
            user_label.Text = "Select User";
            // 
            // user_combobox
            // 
            user_combobox.BackColor = Color.White;
            user_combobox.FormattingEnabled = true;
            user_combobox.Location = new Point(193, 23);
            user_combobox.Name = "user_combobox";
            user_combobox.Size = new Size(182, 33);
            user_combobox.TabIndex = 10;
            user_combobox.SelectedIndexChanged += user_combobox_SelectedIndexChanged;
            // 
            // createnewuser_button
            // 
            createnewuser_button.ForeColor = SystemColors.Desktop;
            createnewuser_button.Location = new Point(126, 62);
            createnewuser_button.Name = "createnewuser_button";
            createnewuser_button.Size = new Size(161, 44);
            createnewuser_button.TabIndex = 11;
            createnewuser_button.Text = "Create New User";
            createnewuser_button.UseVisualStyleBackColor = true;
            createnewuser_button.Click += createnewuser_button_Click;
            // 
            // or_label
            // 
            or_label.AutoSize = true;
            or_label.BackColor = Color.White;
            or_label.ForeColor = SystemColors.Desktop;
            or_label.Location = new Point(91, 72);
            or_label.Name = "or_label";
            or_label.Size = new Size(29, 25);
            or_label.TabIndex = 12;
            or_label.Text = "or";
            or_label.Click += or_label_Click;
            // 
            // finished_button
            // 
            finished_button.ForeColor = SystemColors.Desktop;
            finished_button.Location = new Point(387, 126);
            finished_button.Name = "finished_button";
            finished_button.Size = new Size(112, 136);
            finished_button.TabIndex = 13;
            finished_button.Text = "Finished";
            finished_button.UseVisualStyleBackColor = true;
            finished_button.Click += finished_button_Click;
            // 
            // goals_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 521);
            Controls.Add(finished_button);
            Controls.Add(or_label);
            Controls.Add(createnewuser_button);
            Controls.Add(user_combobox);
            Controls.Add(user_label);
            Controls.Add(addnewcategory_groupbox);
            Controls.Add(amount_label);
            Controls.Add(setgoal_button);
            Controls.Add(category_combobox);
            Controls.Add(amount_textbox);
            Controls.Add(category_label);
            Name = "goals_form";
            Text = "Goals Form";
            addnewcategory_groupbox.ResumeLayout(false);
            addnewcategory_groupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label category_label;
        private TextBox amount_textbox;
        private ComboBox category_combobox;
        private Button setgoal_button;
        private Label amount_label;
        private GroupBox addnewcategory_groupbox;
        private Label newcategory_label;
        private Button addcategory_button;
        private TextBox category_textbox;
        private Label user_label;
        private ComboBox user_combobox;
        private Button createnewuser_button;
        private Label or_label;
        private Button finished_button;
    }
}
