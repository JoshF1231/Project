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
            label6 = new Label();
            label7 = new Label();
            BonusPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 97);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(205, 20);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(583, 23);
            nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 101);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // enableDishCheckBox
            // 
            enableDishCheckBox.AutoSize = true;
            enableDishCheckBox.Location = new Point(701, 62);
            enableDishCheckBox.Name = "enableDishCheckBox";
            enableDishCheckBox.RightToLeft = RightToLeft.Yes;
            enableDishCheckBox.Size = new Size(87, 19);
            enableDishCheckBox.TabIndex = 5;
            enableDishCheckBox.Text = "Enable Dish";
            enableDishCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            enableDishCheckBox.UseVisualStyleBackColor = true;
            // 
            // isVeganCheckBox
            // 
            isVeganCheckBox.AutoSize = true;
            isVeganCheckBox.Location = new Point(632, 61);
            isVeganCheckBox.Name = "isVeganCheckBox";
            isVeganCheckBox.RightToLeft = RightToLeft.Yes;
            isVeganCheckBox.Size = new Size(58, 19);
            isVeganCheckBox.TabIndex = 7;
            isVeganCheckBox.Text = "Vegan";
            isVeganCheckBox.UseVisualStyleBackColor = true;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(205, 138);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(274, 23);
            weightTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 8;
            label3.Text = "Weight:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(205, 182);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(583, 114);
            descriptionTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 185);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Description:";
            // 
            // applyButton
            // 
            applyButton.Location = new Point(623, 596);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 12;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(713, 596);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 62);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 14;
            label5.Text = "Type:";
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Hamburger", "Pizza", "Pasta" });
            typeComboBox.Location = new Point(205, 61);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(274, 23);
            typeComboBox.TabIndex = 15;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(205, 98);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(274, 23);
            priceTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(485, 101);
            label6.Name = "label6";
            label6.Size = new Size(155, 15);
            label6.TabIndex = 16;
            label6.Text = "Please enter a valid number.";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(485, 141);
            label7.Name = "label7";
            label7.Size = new Size(155, 15);
            label7.TabIndex = 17;
            label7.Text = "Please enter a valid number.";
            label7.Visible = false;
            // 
            // BonusPanel
            // 
            BonusPanel.ColumnCount = 2;
            BonusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.7979F));
            BonusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2021F));
            BonusPanel.Location = new Point(26, 337);
            BonusPanel.Name = "BonusPanel";
            BonusPanel.RowCount = 1;
            BonusPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BonusPanel.Size = new Size(762, 242);
            BonusPanel.TabIndex = 18;
            // 
            // MenuItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 631);
            Controls.Add(BonusPanel);
            Controls.Add(label7);
            Controls.Add(label6);
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
            Name = "MenuItemForm";
            Text = "MenuItemForm";
            Load += MenuItemForm_Load;
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
        private Label label6;
        private Label label7;
        private TableLayoutPanel BonusPanel;
    }
}