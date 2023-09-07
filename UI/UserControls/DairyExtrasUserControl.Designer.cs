namespace Project.UI.UserControls
{
    partial class DairyExtrasUserControl
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
            ExtrasLabel = new Label();
            pictureBoxPickles = new PictureBox();
            pictureBoxLettuce = new PictureBox();
            CheeseCheckBox = new CheckBox();
            ButterCheckBox = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLettuce).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(ExtrasLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 44);
            panel1.TabIndex = 39;
            // 
            // ExtrasLabel
            // 
            ExtrasLabel.AutoSize = true;
            ExtrasLabel.Font = new Font("David", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ExtrasLabel.Location = new Point(66, 7);
            ExtrasLabel.Margin = new Padding(2, 0, 2, 0);
            ExtrasLabel.Name = "ExtrasLabel";
            ExtrasLabel.Size = new Size(96, 32);
            ExtrasLabel.TabIndex = 0;
            ExtrasLabel.Text = "Extras";
            // 
            // pictureBoxPickles
            // 
            pictureBoxPickles.Image = Properties.Resources.buttericon;
            pictureBoxPickles.Location = new Point(30, 153);
            pictureBoxPickles.Margin = new Padding(2);
            pictureBoxPickles.Name = "pictureBoxPickles";
            pictureBoxPickles.Size = new Size(50, 40);
            pictureBoxPickles.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPickles.TabIndex = 49;
            pictureBoxPickles.TabStop = false;
            // 
            // pictureBoxLettuce
            // 
            pictureBoxLettuce.Image = Properties.Resources.icons8_cheese_64;
            pictureBoxLettuce.Location = new Point(32, 75);
            pictureBoxLettuce.Margin = new Padding(2);
            pictureBoxLettuce.Name = "pictureBoxLettuce";
            pictureBoxLettuce.Size = new Size(43, 39);
            pictureBoxLettuce.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLettuce.TabIndex = 41;
            pictureBoxLettuce.TabStop = false;
            // 
            // CheeseCheckBox
            // 
            CheeseCheckBox.AutoSize = true;
            CheeseCheckBox.Location = new Point(86, 81);
            CheeseCheckBox.Margin = new Padding(2);
            CheeseCheckBox.Name = "CheeseCheckBox";
            CheeseCheckBox.Size = new Size(93, 19);
            CheeseCheckBox.TabIndex = 44;
            CheeseCheckBox.Text = "Extra Cheese";
            CheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // ButterCheckBox
            // 
            ButterCheckBox.AutoSize = true;
            ButterCheckBox.Location = new Point(86, 157);
            ButterCheckBox.Margin = new Padding(2);
            ButterCheckBox.Name = "ButterCheckBox";
            ButterCheckBox.Size = new Size(87, 19);
            ButterCheckBox.TabIndex = 45;
            ButterCheckBox.Text = "Extra Butter";
            ButterCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExtrasUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBoxPickles);
            Controls.Add(ButterCheckBox);
            Controls.Add(CheeseCheckBox);
            Controls.Add(pictureBoxLettuce);
            Margin = new Padding(2);
            Name = "ExtrasUserControl";
            Size = new Size(219, 233);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLettuce).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ExtrasLabel;
        private PictureBox pictureBoxPickles;
        private PictureBox pictureBoxLettuce;
        private CheckBox CheeseCheckBox;
        private CheckBox ButterCheckBox;
    }
}
