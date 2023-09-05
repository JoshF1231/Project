namespace Project
{
    partial class MenuItemForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            enableDishCheckBox = new CheckBox();
            isVeganCheckBox = new CheckBox();
            weightTextBox = new TextBox();
            label3 = new Label();
            descriptionTextBox = new TextBox();
            label4 = new Label();
            applyButton = new Button();
            cancelButton = new Button();
            label5 = new Label();
            typeComboBox = new ComboBox();
            priceTextBox = new TextBox();
            priceWarningLabel = new Label();
            weightWarningLabel = new Label();
            BonusPanel = new TableLayoutPanel();
            MeatBasedPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 31);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 161);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(292, 34);
            nameTextBox.Margin = new Padding(4, 5, 4, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(832, 31);
            nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // enableDishCheckBox
            // 
            enableDishCheckBox.AutoSize = true;
            enableDishCheckBox.Location = new Point(962, 104);
            enableDishCheckBox.Margin = new Padding(4, 5, 4, 5);
            enableDishCheckBox.Name = "enableDishCheckBox";
            enableDishCheckBox.RightToLeft = RightToLeft.Yes;
            enableDishCheckBox.Size = new Size(130, 29);
            enableDishCheckBox.TabIndex = 5;
            enableDishCheckBox.Text = "Enable Dish";
            enableDishCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            enableDishCheckBox.UseVisualStyleBackColor = true;
            // 
            // isVeganCheckBox
            // 
            isVeganCheckBox.AutoSize = true;
            isVeganCheckBox.Location = new Point(1005, 75);
            isVeganCheckBox.Margin = new Padding(4, 5, 4, 5);
            isVeganCheckBox.Name = "isVeganCheckBox";
            isVeganCheckBox.RightToLeft = RightToLeft.Yes;
            isVeganCheckBox.Size = new Size(87, 29);
            isVeganCheckBox.TabIndex = 7;
            isVeganCheckBox.Text = "Vegan";
            isVeganCheckBox.UseVisualStyleBackColor = true;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(292, 230);
            weightTextBox.Margin = new Padding(4, 5, 4, 5);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(390, 31);
            weightTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 235);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 8;
            label3.Text = "Weight:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(292, 304);
            descriptionTextBox.Margin = new Padding(4, 5, 4, 5);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(832, 188);
            descriptionTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 309);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 10;
            label4.Text = "Description:";
            // 
            // applyButton
            // 
            applyButton.Location = new Point(984, 160);
            applyButton.Margin = new Padding(4, 5, 4, 5);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(108, 39);
            applyButton.TabIndex = 12;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(984, 222);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(108, 39);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 14;
            label5.Text = "Type:";
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Hamburger", "Pizza", "Pasta" });
            typeComboBox.Location = new Point(292, 101);
            typeComboBox.Margin = new Padding(4, 5, 4, 5);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(390, 33);
            typeComboBox.TabIndex = 15;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(292, 164);
            priceTextBox.Margin = new Padding(4, 5, 4, 5);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(390, 31);
            priceTextBox.TabIndex = 4;
            // 
            // priceWarningLabel
            // 
            priceWarningLabel.AutoSize = true;
            priceWarningLabel.ForeColor = Color.Red;
            priceWarningLabel.Location = new Point(692, 169);
            priceWarningLabel.Margin = new Padding(4, 0, 4, 0);
            priceWarningLabel.Name = "priceWarningLabel";
            priceWarningLabel.Size = new Size(233, 25);
            priceWarningLabel.TabIndex = 16;
            priceWarningLabel.Text = "Please enter a valid number.";
            priceWarningLabel.Visible = false;
            // 
            // weightWarningLabel
            // 
            weightWarningLabel.AutoSize = true;
            weightWarningLabel.ForeColor = Color.Red;
            weightWarningLabel.Location = new Point(692, 235);
            weightWarningLabel.Margin = new Padding(4, 0, 4, 0);
            weightWarningLabel.Name = "weightWarningLabel";
            weightWarningLabel.Size = new Size(233, 25);
            weightWarningLabel.TabIndex = 17;
            weightWarningLabel.Text = "Please enter a valid number.";
            weightWarningLabel.Visible = false;
            // 
            // BonusPanel
            // 
            BonusPanel.ColumnCount = 2;
            BonusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.7979F));
            BonusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2021F));
            BonusPanel.Location = new Point(38, 568);
            BonusPanel.Margin = new Padding(4, 5, 4, 5);
            BonusPanel.Name = "BonusPanel";
            BonusPanel.RowCount = 1;
            BonusPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BonusPanel.Size = new Size(1086, 429);
            BonusPanel.TabIndex = 18;
            // 
            // MeatBasedPanel
            // 
            MeatBasedPanel.Location = new Point(700, 73);
            MeatBasedPanel.Name = "MeatBasedPanel";
            MeatBasedPanel.Size = new Size(215, 93);
            MeatBasedPanel.TabIndex = 19;
            // 
            // MenuItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 1051);
            Controls.Add(MeatBasedPanel);
            Controls.Add(BonusPanel);
            Controls.Add(weightWarningLabel);
            Controls.Add(priceWarningLabel);
            Controls.Add(typeComboBox);
            Controls.Add(label5);
            Controls.Add(cancelButton);
            Controls.Add(applyButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(label4);
            Controls.Add(weightTextBox);
            Controls.Add(label3);
            Controls.Add(isVeganCheckBox);
            Controls.Add(enableDishCheckBox);
            Controls.Add(priceTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuItemForm";
            Text = "MenuItemForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private CheckBox enableDishCheckBox;
        private CheckBox isVeganCheckBox;
        private TextBox weightTextBox;
        private Label label3;
        private TextBox descriptionTextBox;
        private Label label4;
        private Button applyButton;
        private Button cancelButton;
        private Label label5;
        private ComboBox typeComboBox;
        private TextBox priceTextBox;
        private Label priceWarningLabel;
        private Label weightWarningLabel;
        private TableLayoutPanel BonusPanel;
        private Panel MeatBasedPanel;
    }
}