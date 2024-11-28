namespace TrackerLibrary
{
    partial class SummaryForm
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
            daysummary_label = new Label();
            usersummary_label = new Label();
            usersummary_combobox = new ComboBox();
            categoryselection_groupbox = new GroupBox();
            getsummary2_button = new Button();
            label6 = new Label();
            category1_combobox = new ComboBox();
            usersummary_listbox = new ListBox();
            percentage_button = new Button();
            remove_button = new Button();
            add_selected_button = new Button();
            categoryselection_groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // daysummary_label
            // 
            daysummary_label.AutoSize = true;
            daysummary_label.BackColor = Color.White;
            daysummary_label.ForeColor = SystemColors.Desktop;
            daysummary_label.Location = new Point(506, 180);
            daysummary_label.Name = "daysummary_label";
            daysummary_label.Size = new Size(0, 25);
            daysummary_label.TabIndex = 11;
            // 
            // usersummary_label
            // 
            usersummary_label.AutoSize = true;
            usersummary_label.BackColor = Color.White;
            usersummary_label.ForeColor = SystemColors.Desktop;
            usersummary_label.Location = new Point(12, 9);
            usersummary_label.Name = "usersummary_label";
            usersummary_label.Size = new Size(47, 25);
            usersummary_label.TabIndex = 12;
            usersummary_label.Text = "User";
            // 
            // usersummary_combobox
            // 
            usersummary_combobox.BackColor = Color.White;
            usersummary_combobox.FormattingEnabled = true;
            usersummary_combobox.Location = new Point(80, 6);
            usersummary_combobox.Name = "usersummary_combobox";
            usersummary_combobox.Size = new Size(182, 33);
            usersummary_combobox.TabIndex = 13;
            // 
            // categoryselection_groupbox
            // 
            categoryselection_groupbox.Controls.Add(getsummary2_button);
            categoryselection_groupbox.Controls.Add(label6);
            categoryselection_groupbox.Controls.Add(category1_combobox);
            categoryselection_groupbox.ForeColor = SystemColors.Desktop;
            categoryselection_groupbox.Location = new Point(14, 161);
            categoryselection_groupbox.Name = "categoryselection_groupbox";
            categoryselection_groupbox.Size = new Size(248, 173);
            categoryselection_groupbox.TabIndex = 19;
            categoryselection_groupbox.TabStop = false;
            categoryselection_groupbox.Text = "Select Category";
            // 
            // getsummary2_button
            // 
            getsummary2_button.Location = new Point(6, 100);
            getsummary2_button.Name = "getsummary2_button";
            getsummary2_button.Size = new Size(236, 34);
            getsummary2_button.TabIndex = 24;
            getsummary2_button.Text = "Get Summary";
            getsummary2_button.UseVisualStyleBackColor = true;
            getsummary2_button.Click += getsummary2_button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(6, 72);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 22;
            // 
            // category1_combobox
            // 
            category1_combobox.BackColor = Color.White;
            category1_combobox.FormattingEnabled = true;
            category1_combobox.Location = new Point(34, 29);
            category1_combobox.Name = "category1_combobox";
            category1_combobox.Size = new Size(182, 33);
            category1_combobox.TabIndex = 13;
            // 
            // usersummary_listbox
            // 
            usersummary_listbox.BackColor = Color.White;
            usersummary_listbox.ForeColor = SystemColors.Desktop;
            usersummary_listbox.FormattingEnabled = true;
            usersummary_listbox.ItemHeight = 25;
            usersummary_listbox.Location = new Point(277, 76);
            usersummary_listbox.Name = "usersummary_listbox";
            usersummary_listbox.Size = new Size(359, 379);
            usersummary_listbox.TabIndex = 20;
            // 
            // percentage_button
            // 
            percentage_button.Location = new Point(367, 464);
            percentage_button.Name = "percentage_button";
            percentage_button.Size = new Size(176, 59);
            percentage_button.TabIndex = 21;
            percentage_button.Text = "View Percentage";
            percentage_button.UseVisualStyleBackColor = true;
            percentage_button.Click += percentage_button_Click;
            // 
            // remove_button
            // 
            remove_button.Location = new Point(659, 285);
            remove_button.Name = "remove_button";
            remove_button.Size = new Size(112, 102);
            remove_button.TabIndex = 22;
            remove_button.Text = "Remove Selected";
            remove_button.UseVisualStyleBackColor = true;
            remove_button.Click += remove_button_Click;
            // 
            // add_selected_button
            // 
            add_selected_button.Location = new Point(659, 103);
            add_selected_button.Name = "add_selected_button";
            add_selected_button.Size = new Size(112, 102);
            add_selected_button.TabIndex = 23;
            add_selected_button.Text = "Add Selected";
            add_selected_button.UseVisualStyleBackColor = true;
            add_selected_button.Click += add_selected_button_Click;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 535);
            Controls.Add(add_selected_button);
            Controls.Add(remove_button);
            Controls.Add(percentage_button);
            Controls.Add(usersummary_listbox);
            Controls.Add(categoryselection_groupbox);
            Controls.Add(usersummary_combobox);
            Controls.Add(usersummary_label);
            Controls.Add(daysummary_label);
            ForeColor = SystemColors.Desktop;
            Name = "SummaryForm";
            Text = "Summary";
            categoryselection_groupbox.ResumeLayout(false);
            categoryselection_groupbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label daysummary_label;
        private Label usersummary_label;
        private ComboBox usersummary_combobox;
        private GroupBox categoryselection_groupbox;
        private ComboBox category1_combobox;
        private Label label6;
        private ListBox usersummary_listbox;
        private Button percentage_button;
        private Button remove_button;
        private Button add_selected_button;
        private Button getsummary2_button;
    }
}