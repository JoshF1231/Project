namespace Project.UI.UserControls
{
    partial class MeatBased
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLabel = new Label();
            ContentLabel = new Label();
            DescriptionLabel = new Label();
            NameTextBox = new TextBox();
            ContentTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            PriceLabel = new Label();
            PriceTextBox = new TextBox();
            AddButton = new Button();
            ClearButton = new Button();
            ButterCheckBox = new CheckBox();
            label1 = new Label();
            CheeseCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(42, 26);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(77, 24);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            // 
            // ContentLabel
            // 
            ContentLabel.AutoSize = true;
            ContentLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContentLabel.Location = new Point(42, 64);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(96, 24);
            ContentLabel.TabIndex = 1;
            ContentLabel.Text = "Content:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(42, 103);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(132, 24);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.Click += label3_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(170, 19);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(151, 31);
            NameTextBox.TabIndex = 3;
            // 
            // ContentTextBox
            // 
            ContentTextBox.Location = new Point(170, 56);
            ContentTextBox.Name = "ContentTextBox";
            ContentTextBox.Size = new Size(151, 31);
            ContentTextBox.TabIndex = 4;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(170, 103);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(151, 134);
            DescriptionTextBox.TabIndex = 6;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(42, 253);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(69, 24);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price:";
            PriceLabel.Click += PriceLabel_Click;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(170, 246);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(151, 31);
            PriceTextBox.TabIndex = 8;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(42, 298);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 9;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(197, 298);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ButterCheckBox
            // 
            ButterCheckBox.AutoSize = true;
            ButterCheckBox.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButterCheckBox.Location = new Point(42, 200);
            ButterCheckBox.Name = "ButterCheckBox";
            ButterCheckBox.Size = new Size(97, 28);
            ButterCheckBox.TabIndex = 27;
            ButterCheckBox.Text = "Butter";
            ButterCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 139);
            label1.Name = "label1";
            label1.Size = new Size(81, 24);
            label1.TabIndex = 28;
            label1.Text = "Extras:";
            // 
            // CheeseCheckBox
            // 
            CheeseCheckBox.AutoSize = true;
            CheeseCheckBox.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheeseCheckBox.Location = new Point(42, 166);
            CheeseCheckBox.Name = "CheeseCheckBox";
            CheeseCheckBox.Size = new Size(106, 28);
            CheeseCheckBox.TabIndex = 29;
            CheeseCheckBox.Text = "Cheese";
            CheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // MeatBased
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CheeseCheckBox);
            Controls.Add(label1);
            Controls.Add(ButterCheckBox);
            Controls.Add(ClearButton);
            Controls.Add(AddButton);
            Controls.Add(PriceTextBox);
            Controls.Add(PriceLabel);
            Controls.Add(DescriptionTextBox);
            Controls.Add(ContentTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(ContentLabel);
            Controls.Add(NameLabel);
            Name = "MeatBased";
            Size = new Size(378, 353);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label ContentLabel;
        private Label DescriptionLabel;
        private TextBox NameTextBox;
        private TextBox ContentTextBox;
        private TextBox DescriptionTextBox;
        private Label PriceLabel;
        private TextBox PriceTextBox;
        private Button AddButton;
        private Button ClearButton;
        private CheckBox ButterCheckBox;
        private Label label1;
        private CheckBox CheeseCheckBox;
    }
}
