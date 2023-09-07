namespace Project.UI.UserControls
{
    partial class MeatExtrasUserControl
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
            pictureBox1 = new PictureBox();
            rareButton = new RadioButton();
            mediumButton = new RadioButton();
            wellDoneButton = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLettuce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(ExtrasLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 44);
            panel1.TabIndex = 52;
            // 
            // ExtrasLabel
            // 
            ExtrasLabel.AutoSize = true;
            ExtrasLabel.BackColor = Color.SaddleBrown;
            ExtrasLabel.Font = new Font("David", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ExtrasLabel.Location = new Point(42, 8);
            ExtrasLabel.Margin = new Padding(2, 0, 2, 0);
            ExtrasLabel.Name = "ExtrasLabel";
            ExtrasLabel.Size = new Size(137, 32);
            ExtrasLabel.TabIndex = 0;
            ExtrasLabel.Text = "Doneness";
            // 
            // pictureBoxPickles
            // 
            pictureBoxPickles.Image = Properties.Resources.medium;
            pictureBoxPickles.Location = new Point(26, 110);
            pictureBoxPickles.Margin = new Padding(2);
            pictureBoxPickles.Name = "pictureBoxPickles";
            pictureBoxPickles.Size = new Size(59, 52);
            pictureBoxPickles.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPickles.TabIndex = 56;
            pictureBoxPickles.TabStop = false;
            // 
            // pictureBoxLettuce
            // 
            pictureBoxLettuce.Image = Properties.Resources.rare;
            pictureBoxLettuce.Location = new Point(26, 49);
            pictureBoxLettuce.Margin = new Padding(2);
            pictureBoxLettuce.Name = "pictureBoxLettuce";
            pictureBoxLettuce.Size = new Size(59, 52);
            pictureBoxLettuce.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLettuce.TabIndex = 53;
            pictureBoxLettuce.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.well_done;
            pictureBox1.Location = new Point(26, 169);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // rareButton
            // 
            rareButton.AutoSize = true;
            rareButton.Location = new Point(90, 66);
            rareButton.Name = "rareButton";
            rareButton.Size = new Size(48, 19);
            rareButton.TabIndex = 58;
            rareButton.TabStop = true;
            rareButton.Text = "Rare";
            rareButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            mediumButton.AutoSize = true;
            mediumButton.Location = new Point(90, 127);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(70, 19);
            mediumButton.TabIndex = 59;
            mediumButton.TabStop = true;
            mediumButton.Text = "Medium";
            mediumButton.UseVisualStyleBackColor = true;
            // 
            // wellDoneButton
            // 
            wellDoneButton.AutoSize = true;
            wellDoneButton.Location = new Point(90, 185);
            wellDoneButton.Name = "wellDoneButton";
            wellDoneButton.Size = new Size(79, 19);
            wellDoneButton.TabIndex = 60;
            wellDoneButton.TabStop = true;
            wellDoneButton.Text = "Well Done";
            wellDoneButton.UseVisualStyleBackColor = true;
            // 
            // MeatExtrasUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(wellDoneButton);
            Controls.Add(mediumButton);
            Controls.Add(rareButton);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxPickles);
            Controls.Add(pictureBoxLettuce);
            Name = "MeatExtrasUserControl";
            Size = new Size(219, 233);
            Load += MeatExtras_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLettuce).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ExtrasLabel;
        private Label veganButterLabel;
        private Label VeganCheeseLabel;
        private PictureBox pictureBoxPickles;
        private PictureBox pictureBoxLettuce;
        private PictureBox pictureBox1;
        private RadioButton rareButton;
        private RadioButton mediumButton;
        private RadioButton wellDoneButton;
    }
}
