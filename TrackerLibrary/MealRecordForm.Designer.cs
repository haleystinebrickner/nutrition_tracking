namespace TrackerLibrary
{
    partial class MealRecording
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
            usermeal_label = new Label();
            usermeal_combobox = new ComboBox();
            categorymeal_label = new Label();
            categorymeal_combobox = new ComboBox();
            amountmeal_label = new Label();
            amountmeal_textbox = new TextBox();
            recordmeal_button = new Button();
            recordmeal_groupbox = new GroupBox();
            recordedmeals_listbox = new ListBox();
            see_percent_button = new Button();
            deletemeal_button = new Button();
            recordmeal_groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // usermeal_label
            // 
            usermeal_label.AutoSize = true;
            usermeal_label.BackColor = Color.White;
            usermeal_label.ForeColor = SystemColors.Desktop;
            usermeal_label.Location = new Point(65, 31);
            usermeal_label.Name = "usermeal_label";
            usermeal_label.Size = new Size(47, 25);
            usermeal_label.TabIndex = 10;
            usermeal_label.Text = "User";
            // 
            // usermeal_combobox
            // 
            usermeal_combobox.BackColor = Color.White;
            usermeal_combobox.FormattingEnabled = true;
            usermeal_combobox.Location = new Point(136, 28);
            usermeal_combobox.Name = "usermeal_combobox";
            usermeal_combobox.Size = new Size(182, 33);
            usermeal_combobox.TabIndex = 11;
            usermeal_combobox.SelectedIndexChanged += usermeal_combobox_SelectedIndexChanged;
            // 
            // categorymeal_label
            // 
            categorymeal_label.AutoSize = true;
            categorymeal_label.BackColor = Color.White;
            categorymeal_label.ForeColor = SystemColors.Desktop;
            categorymeal_label.Location = new Point(13, 68);
            categorymeal_label.Name = "categorymeal_label";
            categorymeal_label.Size = new Size(84, 25);
            categorymeal_label.TabIndex = 12;
            categorymeal_label.Text = "Category";
            // 
            // categorymeal_combobox
            // 
            categorymeal_combobox.BackColor = Color.White;
            categorymeal_combobox.FormattingEnabled = true;
            categorymeal_combobox.Location = new Point(121, 68);
            categorymeal_combobox.Name = "categorymeal_combobox";
            categorymeal_combobox.Size = new Size(182, 33);
            categorymeal_combobox.TabIndex = 13;
            // 
            // amountmeal_label
            // 
            amountmeal_label.AutoSize = true;
            amountmeal_label.BackColor = Color.White;
            amountmeal_label.ForeColor = SystemColors.Desktop;
            amountmeal_label.Location = new Point(20, 132);
            amountmeal_label.Name = "amountmeal_label";
            amountmeal_label.Size = new Size(77, 25);
            amountmeal_label.TabIndex = 14;
            amountmeal_label.Text = "Amount";
            // 
            // amountmeal_textbox
            // 
            amountmeal_textbox.BackColor = Color.White;
            amountmeal_textbox.Location = new Point(121, 129);
            amountmeal_textbox.Name = "amountmeal_textbox";
            amountmeal_textbox.Size = new Size(84, 31);
            amountmeal_textbox.TabIndex = 15;
            // 
            // recordmeal_button
            // 
            recordmeal_button.Location = new Point(73, 202);
            recordmeal_button.Name = "recordmeal_button";
            recordmeal_button.Size = new Size(171, 34);
            recordmeal_button.TabIndex = 16;
            recordmeal_button.Text = "Record";
            recordmeal_button.UseVisualStyleBackColor = true;
            recordmeal_button.Click += recordmeal_button_Click;
            // 
            // recordmeal_groupbox
            // 
            recordmeal_groupbox.Controls.Add(categorymeal_combobox);
            recordmeal_groupbox.Controls.Add(recordmeal_button);
            recordmeal_groupbox.Controls.Add(categorymeal_label);
            recordmeal_groupbox.Controls.Add(amountmeal_textbox);
            recordmeal_groupbox.Controls.Add(amountmeal_label);
            recordmeal_groupbox.ForeColor = SystemColors.Desktop;
            recordmeal_groupbox.Location = new Point(22, 119);
            recordmeal_groupbox.Name = "recordmeal_groupbox";
            recordmeal_groupbox.Size = new Size(329, 288);
            recordmeal_groupbox.TabIndex = 18;
            recordmeal_groupbox.TabStop = false;
            recordmeal_groupbox.Text = "Record Meal";
            // 
            // recordedmeals_listbox
            // 
            recordedmeals_listbox.ForeColor = SystemColors.Desktop;
            recordedmeals_listbox.FormattingEnabled = true;
            recordedmeals_listbox.ItemHeight = 25;
            recordedmeals_listbox.Location = new Point(398, 26);
            recordedmeals_listbox.Name = "recordedmeals_listbox";
            recordedmeals_listbox.Size = new Size(355, 329);
            recordedmeals_listbox.TabIndex = 19;
            // 
            // see_percent_button
            // 
            see_percent_button.Location = new Point(603, 361);
            see_percent_button.Name = "see_percent_button";
            see_percent_button.Size = new Size(150, 77);
            see_percent_button.TabIndex = 20;
            see_percent_button.Text = "Daily Summary";
            see_percent_button.UseVisualStyleBackColor = true;
            see_percent_button.Click += see_percent_button_Click;
            // 
            // deletemeal_button
            // 
            deletemeal_button.Location = new Point(407, 382);
            deletemeal_button.Name = "deletemeal_button";
            deletemeal_button.Size = new Size(182, 34);
            deletemeal_button.TabIndex = 21;
            deletemeal_button.Text = "Delete Selected";
            deletemeal_button.UseVisualStyleBackColor = true;
            deletemeal_button.Click += deletemeal_button_Click;
            // 
            // MealRecording
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(deletemeal_button);
            Controls.Add(see_percent_button);
            Controls.Add(recordedmeals_listbox);
            Controls.Add(recordmeal_groupbox);
            Controls.Add(usermeal_combobox);
            Controls.Add(usermeal_label);
            ForeColor = SystemColors.Desktop;
            Name = "MealRecording";
            Text = "Meal Recording";
            recordmeal_groupbox.ResumeLayout(false);
            recordmeal_groupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usermeal_label;
        private ComboBox usermeal_combobox;
        private Label categorymeal_label;
        private ComboBox categorymeal_combobox;
        private Label amountmeal_label;
        private TextBox amountmeal_textbox;
        private Button recordmeal_button;
        private GroupBox recordmeal_groupbox;
        private ListBox recordedmeals_listbox;
        private Button see_percent_button;
        private Button deletemeal_button;
    }
}