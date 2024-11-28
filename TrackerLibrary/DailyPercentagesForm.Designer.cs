namespace TrackerLibrary
{
    partial class DailyPercentagesForm
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
            categorypercentage_label = new Label();
            seemore_button = new Button();
            category_percent_dropdown = new ComboBox();
            ProgressButton = new Button();
            SuspendLayout();
            // 
            // categorypercentage_label
            // 
            categorypercentage_label.AutoSize = true;
            categorypercentage_label.BackColor = Color.White;
            categorypercentage_label.ForeColor = SystemColors.Desktop;
            categorypercentage_label.Location = new Point(161, 43);
            categorypercentage_label.Name = "categorypercentage_label";
            categorypercentage_label.Size = new Size(84, 25);
            categorypercentage_label.TabIndex = 14;
            categorypercentage_label.Text = "Category";
            categorypercentage_label.Click += firstname_label_Click;
            // 
            // seemore_button
            // 
            seemore_button.ForeColor = SystemColors.Desktop;
            seemore_button.Location = new Point(99, 202);
            seemore_button.Name = "seemore_button";
            seemore_button.Size = new Size(199, 34);
            seemore_button.TabIndex = 18;
            seemore_button.Text = "See More Percentages";
            seemore_button.UseVisualStyleBackColor = true;
            seemore_button.Click += seemore_button_Click;
            // 
            // category_percent_dropdown
            // 
            category_percent_dropdown.FormattingEnabled = true;
            category_percent_dropdown.Location = new Point(116, 101);
            category_percent_dropdown.Name = "category_percent_dropdown";
            category_percent_dropdown.Size = new Size(182, 33);
            category_percent_dropdown.TabIndex = 19;
            // 
            // ProgressButton
            // 
            ProgressButton.ForeColor = SystemColors.Desktop;
            ProgressButton.Location = new Point(326, 74);
            ProgressButton.Name = "ProgressButton";
            ProgressButton.Size = new Size(90, 85);
            ProgressButton.TabIndex = 22;
            ProgressButton.Text = "See Progress";
            ProgressButton.UseVisualStyleBackColor = true;
            ProgressButton.Click += ProgressButton_Click;
            // 
            // DailyPercentagesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(451, 303);
            Controls.Add(ProgressButton);
            Controls.Add(category_percent_dropdown);
            Controls.Add(seemore_button);
            Controls.Add(categorypercentage_label);
            Name = "DailyPercentagesForm";
            Text = "DailyPercentages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categorypercentage_label;
        private Button seemore_button;
        private ComboBox category_percent_dropdown;
        private Button ProgressButton;
    }
}