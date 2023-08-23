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
            Temporary.Location = new Point(101, 41);
            Temporary.Name = "Temporary";
            Temporary.Size = new Size(158, 27);
            Temporary.TabIndex = 1;
            Temporary.Text = "MENU FORM";
            // 
            // test
            // 
            test.Location = new Point(550, 128);
            test.Name = "test";
            test.Size = new Size(100, 23);
            test.TabIndex = 2;
            // 
            // listBoxDishes
            // 
            listBoxDishes.FormattingEnabled = true;
            listBoxDishes.ItemHeight = 15;
            listBoxDishes.Location = new Point(101, 128);
            listBoxDishes.Name = "listBoxDishes";
            listBoxDishes.Size = new Size(120, 289);
            listBoxDishes.TabIndex = 3;
            listBoxDishes.SelectedIndexChanged += listBoxDishes_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(264, 127);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(264, 156);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 5;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Location = new Point(550, 101);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(63, 15);
            tempLabel.TabIndex = 6;
            tempLabel.Text = "tempLabel";
            // 
            // dishNameTextbox
            // 
            dishNameTextbox.Location = new Point(101, 93);
            dishNameTextbox.Name = "dishNameTextbox";
            dishNameTextbox.Size = new Size(100, 23);
            dishNameTextbox.TabIndex = 7;
            dishNameTextbox.KeyDown += dishNameTextbox_KeyDown;
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.BackColor = Color.White;
            warning.ForeColor = Color.IndianRed;
            warning.Location = new Point(264, 101);
            warning.Name = "warning";
            warning.Size = new Size(110, 15);
            warning.TabIndex = 8;
            warning.Text = "Select a branch first";
            warning.Visible = false;
            // 
            // dishNameLabel
            // 
            dishNameLabel.AutoSize = true;
            dishNameLabel.Location = new Point(18, 96);
            dishNameLabel.Name = "dishNameLabel";
            dishNameLabel.Size = new Size(66, 15);
            dishNameLabel.TabIndex = 9;
            dishNameLabel.Text = "Dish name:";
            // 
            // Menu_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(797, 496);
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