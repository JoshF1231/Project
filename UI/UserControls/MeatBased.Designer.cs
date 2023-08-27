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
            panel1 = new Panel();
            MeatLabel = new Label();
            MeatBasedTypeBox = new ComboBox();
            TypeLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(42, 157);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(77, 24);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            // 
            // ContentLabel
            // 
            ContentLabel.AutoSize = true;
            ContentLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContentLabel.Location = new Point(42, 205);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(96, 24);
            ContentLabel.TabIndex = 1;
            ContentLabel.Text = "Content:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(42, 260);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(132, 24);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.Click += label3_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(170, 157);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(151, 31);
            NameTextBox.TabIndex = 3;
            // 
            // ContentTextBox
            // 
            ContentTextBox.Location = new Point(170, 205);
            ContentTextBox.Name = "ContentTextBox";
            ContentTextBox.Size = new Size(151, 31);
            ContentTextBox.TabIndex = 4;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(170, 260);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(151, 134);
            DescriptionTextBox.TabIndex = 6;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(42, 430);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(69, 24);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price:";
            PriceLabel.Click += PriceLabel_Click;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(170, 430);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(151, 31);
            PriceTextBox.TabIndex = 8;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(55, 484);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 9;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(224, 484);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(MeatLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 74);
            panel1.TabIndex = 11;
            // 
            // MeatLabel
            // 
            MeatLabel.AutoSize = true;
            MeatLabel.Font = new Font("David", 24F, FontStyle.Regular, GraphicsUnit.Point);
            MeatLabel.Location = new Point(75, 13);
            MeatLabel.Name = "MeatLabel";
            MeatLabel.Size = new Size(235, 47);
            MeatLabel.TabIndex = 0;
            MeatLabel.Text = "MeatBased";
            // 
            // MeatBasedTypeBox
            // 
            MeatBasedTypeBox.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MeatBasedTypeBox.FormattingEnabled = true;
            MeatBasedTypeBox.Location = new Point(171, 110);
            MeatBasedTypeBox.Name = "MeatBasedTypeBox";
            MeatBasedTypeBox.Size = new Size(150, 32);
            MeatBasedTypeBox.TabIndex = 24;
            MeatBasedTypeBox.SelectedIndexChanged += MeatBasedTypeBox_SelectedIndexChanged;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeLabel.Location = new Point(42, 110);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(69, 24);
            TypeLabel.TabIndex = 25;
            TypeLabel.Text = "Type:";
            // 
            // MeatBased
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TypeLabel);
            Controls.Add(MeatBasedTypeBox);
            Controls.Add(panel1);
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
            Size = new Size(392, 558);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label MeatLabel;
        private ComboBox MeatBasedTypeBox;
        private Label TypeLabel;
    }
}
