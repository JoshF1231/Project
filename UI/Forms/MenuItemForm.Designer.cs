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
            dishPictureBox = new PictureBox();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            enableDishCheckBox = new CheckBox();
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
            typeWarningLabel = new Label();
            imageUploadButton = new Button();
            nameWarningLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dishPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dishPictureBox
            // 
            dishPictureBox.Image = Properties.Resources.noimageselected;
            dishPictureBox.Location = new Point(28, 13);
            dishPictureBox.Name = "dishPictureBox";
            dishPictureBox.Size = new Size(168, 146);
            dishPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dishPictureBox.TabIndex = 0;
            dishPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(275, 20);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(274, 23);
            nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 101);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // enableDishCheckBox
            // 
            enableDishCheckBox.AutoSize = true;
            enableDishCheckBox.Location = new Point(701, 24);
            enableDishCheckBox.Name = "enableDishCheckBox";
            enableDishCheckBox.RightToLeft = RightToLeft.Yes;
            enableDishCheckBox.Size = new Size(87, 19);
            enableDishCheckBox.TabIndex = 5;
            enableDishCheckBox.Text = "Enable Dish";
            enableDishCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            enableDishCheckBox.UseVisualStyleBackColor = true;
            enableDishCheckBox.CheckedChanged += enableDishCheckBox_CheckedChanged;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(275, 136);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(274, 23);
            weightTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 139);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 8;
            label3.Text = "Weight:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(275, 182);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(274, 85);
            descriptionTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 185);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Description:";
            // 
            // applyButton
            // 
            applyButton.Location = new Point(712, 553);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(76, 23);
            applyButton.TabIndex = 12;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(630, 553);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(76, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 60);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 14;
            label5.Text = "Type:";
            label5.Click += label5_Click;
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Hamburger", "Pizza", "Pasta" });
            typeComboBox.Location = new Point(275, 60);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(274, 23);
            typeComboBox.TabIndex = 15;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(275, 98);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(274, 23);
            priceTextBox.TabIndex = 4;
            // 
            // priceWarningLabel
            // 
            priceWarningLabel.AutoSize = true;
            priceWarningLabel.ForeColor = Color.Red;
            priceWarningLabel.Location = new Point(555, 99);
            priceWarningLabel.Name = "priceWarningLabel";
            priceWarningLabel.Size = new Size(155, 15);
            priceWarningLabel.TabIndex = 16;
            priceWarningLabel.Text = "Please enter a valid number.";
            priceWarningLabel.Visible = false;
            // 
            // weightWarningLabel
            // 
            weightWarningLabel.AutoSize = true;
            weightWarningLabel.ForeColor = Color.Red;
            weightWarningLabel.Location = new Point(555, 139);
            weightWarningLabel.Name = "weightWarningLabel";
            weightWarningLabel.Size = new Size(155, 15);
            weightWarningLabel.TabIndex = 17;
            weightWarningLabel.Text = "Please enter a valid number.";
            weightWarningLabel.Visible = false;
            // 
            // BonusPanel
            // 
            BonusPanel.ColumnCount = 2;
            BonusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.55263F));
            BonusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.44737F));
            BonusPanel.Location = new Point(28, 290);
            BonusPanel.Name = "BonusPanel";
            BonusPanel.RowCount = 1;
            BonusPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BonusPanel.Size = new Size(760, 257);
            BonusPanel.TabIndex = 18;
            // 
            // typeWarningLabel
            // 
            typeWarningLabel.AutoSize = true;
            typeWarningLabel.ForeColor = Color.Red;
            typeWarningLabel.Location = new Point(555, 63);
            typeWarningLabel.Name = "typeWarningLabel";
            typeWarningLabel.Size = new Size(134, 15);
            typeWarningLabel.TabIndex = 20;
            typeWarningLabel.Text = "Please select a type first.";
            typeWarningLabel.Visible = false;
            // 
            // imageUploadButton
            // 
            imageUploadButton.Location = new Point(73, 165);
            imageUploadButton.Name = "imageUploadButton";
            imageUploadButton.Size = new Size(75, 23);
            imageUploadButton.TabIndex = 21;
            imageUploadButton.Text = "Upload";
            imageUploadButton.UseVisualStyleBackColor = true;
            imageUploadButton.Click += imageUploadButton_Click;
            // 
            // nameWarningLabel
            // 
            nameWarningLabel.AutoSize = true;
            nameWarningLabel.ForeColor = Color.Red;
            nameWarningLabel.Location = new Point(555, 24);
            nameWarningLabel.Name = "nameWarningLabel";
            nameWarningLabel.Size = new Size(115, 15);
            nameWarningLabel.TabIndex = 22;
            nameWarningLabel.Text = "Please enter a name.";
            nameWarningLabel.Visible = false;
            // 
            // MenuItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 586);
            Controls.Add(nameWarningLabel);
            Controls.Add(imageUploadButton);
            Controls.Add(typeWarningLabel);
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
            Controls.Add(enableDishCheckBox);
            Controls.Add(priceTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(dishPictureBox);
            Name = "MenuItemForm";
            Text = "MenuItemForm";
            ((System.ComponentModel.ISupportInitialize)dishPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox dishPictureBox;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private CheckBox enableDishCheckBox;
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
        private Label typeWarningLabel;
        private Button imageUploadButton;
        private Label nameWarningLabel;
    }
}