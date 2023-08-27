namespace Project
{
    partial class Menu_Form
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
            Temporary = new Label();
            test = new TextBox();
            listBoxDishes = new ListBox();
            addButton = new Button();
            removeButton = new Button();
            tempLabel = new Label();
            dishNameTextbox = new TextBox();
            warning = new Label();
            dishNameLabel = new Label();
            SuspendLayout();
            // 
            // Temporary
            // 
            Temporary.AutoSize = true;
            Temporary.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Temporary.Location = new Point(144, 68);
            Temporary.Margin = new Padding(4, 0, 4, 0);
            Temporary.Name = "Temporary";
            Temporary.Size = new Size(238, 41);
            Temporary.TabIndex = 1;
            Temporary.Text = "MENU FORM";
            // 
            // test
            // 
            test.Location = new Point(786, 213);
            test.Margin = new Padding(4, 5, 4, 5);
            test.Name = "test";
            test.Size = new Size(141, 31);
            test.TabIndex = 2;
            // 
            // listBoxDishes
            // 
            listBoxDishes.FormattingEnabled = true;
            listBoxDishes.ItemHeight = 25;
            listBoxDishes.Location = new Point(144, 213);
            listBoxDishes.Margin = new Padding(4, 5, 4, 5);
            listBoxDishes.Name = "listBoxDishes";
            listBoxDishes.Size = new Size(170, 479);
            listBoxDishes.TabIndex = 3;
            listBoxDishes.SelectedIndexChanged += listBoxDishes_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(377, 212);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(107, 38);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(377, 260);
            removeButton.Margin = new Padding(4, 5, 4, 5);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(107, 38);
            removeButton.TabIndex = 5;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Location = new Point(786, 168);
            tempLabel.Margin = new Padding(4, 0, 4, 0);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(95, 25);
            tempLabel.TabIndex = 6;
            tempLabel.Text = "tempLabel";
            // 
            // dishNameTextbox
            // 
            dishNameTextbox.Location = new Point(144, 155);
            dishNameTextbox.Margin = new Padding(4, 5, 4, 5);
            dishNameTextbox.Name = "dishNameTextbox";
            dishNameTextbox.Size = new Size(141, 31);
            dishNameTextbox.TabIndex = 7;
            dishNameTextbox.KeyDown += dishNameTextbox_KeyDown;
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.BackColor = Color.White;
            warning.ForeColor = Color.IndianRed;
            warning.Location = new Point(377, 168);
            warning.Margin = new Padding(4, 0, 4, 0);
            warning.Name = "warning";
            warning.Size = new Size(166, 25);
            warning.TabIndex = 8;
            warning.Text = "Select a branch first";
            warning.Visible = false;
            // 
            // dishNameLabel
            // 
            dishNameLabel.AutoSize = true;
            dishNameLabel.Location = new Point(26, 160);
            dishNameLabel.Margin = new Padding(4, 0, 4, 0);
            dishNameLabel.Name = "dishNameLabel";
            dishNameLabel.Size = new Size(100, 25);
            dishNameLabel.TabIndex = 9;
            dishNameLabel.Text = "Dish name:";
            // 
            // Menu_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 827);
            ControlBox = false;
            Controls.Add(dishNameLabel);
            Controls.Add(warning);
            Controls.Add(dishNameTextbox);
            Controls.Add(tempLabel);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(listBoxDishes);
            Controls.Add(test);
            Controls.Add(Temporary);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu_Form";
            Text = "Menu_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Temporary;
        private TextBox test;
        private ListBox listBoxDishes;
        private Button addButton;
        private Button removeButton;
        private Label tempLabel;
        private TextBox dishNameTextbox;
        private Label warning;
        private Label dishNameLabel;
    }
}