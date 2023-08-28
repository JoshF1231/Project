namespace Project.UI.UserControls
{
    partial class Dairy
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
            ClearButton = new Button();
            AddButton = new Button();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            DescriptionTextBox = new TextBox();
            ContentTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescriptionLabel = new Label();
            ContentLabel = new Label();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(205, 299);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 39;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(50, 299);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 38;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(178, 247);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(151, 31);
            PriceTextBox.TabIndex = 37;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(50, 254);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(69, 24);
            PriceLabel.TabIndex = 36;
            PriceLabel.Text = "Price:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(178, 104);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(151, 134);
            DescriptionTextBox.TabIndex = 35;
            // 
            // ContentTextBox
            // 
            ContentTextBox.Location = new Point(178, 57);
            ContentTextBox.Name = "ContentTextBox";
            ContentTextBox.Size = new Size(151, 31);
            ContentTextBox.TabIndex = 34;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(178, 20);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(151, 31);
            NameTextBox.TabIndex = 33;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(50, 104);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(132, 24);
            DescriptionLabel.TabIndex = 32;
            DescriptionLabel.Text = "Description:";
            // 
            // ContentLabel
            // 
            ContentLabel.AutoSize = true;
            ContentLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContentLabel.Location = new Point(50, 65);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(96, 24);
            ContentLabel.TabIndex = 31;
            ContentLabel.Text = "Content:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(50, 27);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(77, 24);
            NameLabel.TabIndex = 30;
            NameLabel.Text = "Name:";
            // 
            // Dairy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Dairy";
            Size = new Size(378, 353);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ClearButton;
        private Button AddButton;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private TextBox DescriptionTextBox;
        private TextBox ContentTextBox;
        private TextBox NameTextBox;
        private Label DescriptionLabel;
        private Label ContentLabel;
        private Label NameLabel;
    }
}
