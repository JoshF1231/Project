namespace Project.UI.UserControls
{
    partial class ExtrasUserControl
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
            ButterCheckBox = new CheckBox();
            label1 = new Label();
            CheeseCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // ButterCheckBox
            // 
            ButterCheckBox.AutoSize = true;
            ButterCheckBox.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButterCheckBox.Location = new Point(115, 27);
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
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 24);
            label1.TabIndex = 28;
            label1.Text = "Extras:";
            // 
            // CheeseCheckBox
            // 
            CheeseCheckBox.AutoSize = true;
            CheeseCheckBox.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheeseCheckBox.Location = new Point(3, 27);
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
            Name = "MeatBased";
            Size = new Size(215, 63);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox ButterCheckBox;
        private Label label1;
        private CheckBox CheeseCheckBox;
    }
}
