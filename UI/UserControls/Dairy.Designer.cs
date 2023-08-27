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
            panel1 = new Panel();
            DairyLabel = new Label();
            NameLabel = new Label();
            ContentLabel = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            PriceLabel = new Label();
            textBox3 = new TextBox();
            AddButton = new Button();
            ClearButton = new Button();
            DairyTypeBox = new ComboBox();
            TypeLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(DairyLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 74);
            panel1.TabIndex = 12;
            // 
            // DairyLabel
            // 
            DairyLabel.AutoSize = true;
            DairyLabel.Font = new Font("David", 24F, FontStyle.Regular, GraphicsUnit.Point);
            DairyLabel.Location = new Point(117, 14);
            DairyLabel.Name = "DairyLabel";
            DairyLabel.Size = new Size(129, 47);
            DairyLabel.TabIndex = 0;
            DairyLabel.Text = "Dairy";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(42, 157);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(77, 24);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Name:";
            // 
            // ContentLabel
            // 
            ContentLabel.AutoSize = true;
            ContentLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContentLabel.Location = new Point(42, 205);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(96, 24);
            ContentLabel.TabIndex = 14;
            ContentLabel.Text = "Content:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 260);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 15;
            label3.Text = "Details:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 31);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 31);
            textBox2.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 260);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 134);
            textBox4.TabIndex = 18;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(50, 430);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(69, 24);
            PriceLabel.TabIndex = 19;
            PriceLabel.Text = "Price:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 430);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 31);
            textBox3.TabIndex = 20;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(55, 484);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 21;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(224, 484);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 22;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // DairyTypeBox
            // 
            DairyTypeBox.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DairyTypeBox.FormattingEnabled = true;
            DairyTypeBox.Location = new Point(170, 110);
            DairyTypeBox.Name = "DairyTypeBox";
            DairyTypeBox.Size = new Size(150, 32);
            DairyTypeBox.TabIndex = 23;
            DairyTypeBox.SelectedIndexChanged += DairyTypeBox_SelectedIndexChanged;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeLabel.Location = new Point(42, 110);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(69, 24);
            TypeLabel.TabIndex = 24;
            TypeLabel.Text = "Type:";
            // 
            // Dairy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TypeLabel);
            Controls.Add(DairyTypeBox);
            Controls.Add(ClearButton);
            Controls.Add(AddButton);
            Controls.Add(textBox3);
            Controls.Add(PriceLabel);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(ContentLabel);
            Controls.Add(NameLabel);
            Controls.Add(panel1);
            Name = "Dairy";
            Size = new Size(392, 558);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label DairyLabel;
        private Label NameLabel;
        private Label ContentLabel;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label PriceLabel;
        private TextBox textBox3;
        private Button AddButton;
        private Button ClearButton;
        private ComboBox DairyTypeBox;
        private Label TypeLabel;
    }
}
