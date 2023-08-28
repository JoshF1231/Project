namespace Project.UI.UserControls
{
    partial class HamburgerUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HamburgerUserControl));
            panel1 = new Panel();
            HamburgerLabel = new Label();
            IngredientsLabel = new Label();
            pictureBoxLettuce = new PictureBox();
            pictureBoxBacon = new PictureBox();
            pictureBoxPickles = new PictureBox();
            pictureBoxOnion = new PictureBox();
            pictureBoxTomato = new PictureBox();
            checkBoxBacon = new CheckBox();
            checkBoxPickles = new CheckBox();
            checkBoxLettuce = new CheckBox();
            checkBoxOnion = new CheckBox();
            checkBoxTomato = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLettuce).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBacon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOnion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTomato).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(HamburgerLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 74);
            panel1.TabIndex = 13;
            // 
            // HamburgerLabel
            // 
            HamburgerLabel.AutoSize = true;
            HamburgerLabel.Font = new Font("David", 24F, FontStyle.Regular, GraphicsUnit.Point);
            HamburgerLabel.Location = new Point(75, 13);
            HamburgerLabel.Name = "HamburgerLabel";
            HamburgerLabel.Size = new Size(238, 47);
            HamburgerLabel.TabIndex = 0;
            HamburgerLabel.Text = "Hamburger";
            // 
            // IngredientsLabel
            // 
            IngredientsLabel.AutoSize = true;
            IngredientsLabel.Font = new Font("David", 18F, FontStyle.Regular, GraphicsUnit.Point);
            IngredientsLabel.Location = new Point(95, 89);
            IngredientsLabel.Name = "IngredientsLabel";
            IngredientsLabel.Size = new Size(191, 35);
            IngredientsLabel.TabIndex = 20;
            IngredientsLabel.Text = "Ingredients:";
            // 
            // pictureBoxLettuce
            // 
            pictureBoxLettuce.Image = Properties.Resources.icons8_lettuce_64;
            pictureBoxLettuce.Location = new Point(31, 127);
            pictureBoxLettuce.Name = "pictureBoxLettuce";
            pictureBoxLettuce.Size = new Size(61, 65);
            pictureBoxLettuce.TabIndex = 28;
            pictureBoxLettuce.TabStop = false;
            // 
            // pictureBoxBacon
            // 
            pictureBoxBacon.Image = Properties.Resources.bacon_1582218__1_;
            pictureBoxBacon.Location = new Point(112, 276);
            pictureBoxBacon.Name = "pictureBoxBacon";
            pictureBoxBacon.Size = new Size(62, 70);
            pictureBoxBacon.TabIndex = 38;
            pictureBoxBacon.TabStop = false;
            // 
            // pictureBoxPickles
            // 
            pictureBoxPickles.Image = Properties.Resources.zucchini_10632229__1_;
            pictureBoxPickles.Location = new Point(31, 198);
            pictureBoxPickles.Name = "pictureBoxPickles";
            pictureBoxPickles.Size = new Size(62, 62);
            pictureBoxPickles.TabIndex = 37;
            pictureBoxPickles.TabStop = false;
            // 
            // pictureBoxOnion
            // 
            pictureBoxOnion.Image = Properties.Resources.icons8_onion_64;
            pictureBoxOnion.Location = new Point(209, 198);
            pictureBoxOnion.Name = "pictureBoxOnion";
            pictureBoxOnion.Size = new Size(62, 63);
            pictureBoxOnion.TabIndex = 36;
            pictureBoxOnion.TabStop = false;
            // 
            // pictureBoxTomato
            // 
            pictureBoxTomato.Image = (Image)resources.GetObject("pictureBoxTomato.Image");
            pictureBoxTomato.Location = new Point(209, 128);
            pictureBoxTomato.Name = "pictureBoxTomato";
            pictureBoxTomato.Size = new Size(61, 64);
            pictureBoxTomato.TabIndex = 35;
            pictureBoxTomato.TabStop = false;
            // 
            // checkBoxBacon
            // 
            checkBoxBacon.AutoSize = true;
            checkBoxBacon.Location = new Point(185, 317);
            checkBoxBacon.Name = "checkBoxBacon";
            checkBoxBacon.Size = new Size(86, 29);
            checkBoxBacon.TabIndex = 34;
            checkBoxBacon.Text = "Bacon";
            checkBoxBacon.UseVisualStyleBackColor = true;
            // 
            // checkBoxPickles
            // 
            checkBoxPickles.AutoSize = true;
            checkBoxPickles.Location = new Point(95, 231);
            checkBoxPickles.Name = "checkBoxPickles";
            checkBoxPickles.Size = new Size(90, 29);
            checkBoxPickles.TabIndex = 33;
            checkBoxPickles.Text = "Pickles";
            checkBoxPickles.UseVisualStyleBackColor = true;
            // 
            // checkBoxLettuce
            // 
            checkBoxLettuce.AutoSize = true;
            checkBoxLettuce.Location = new Point(95, 163);
            checkBoxLettuce.Name = "checkBoxLettuce";
            checkBoxLettuce.Size = new Size(94, 29);
            checkBoxLettuce.TabIndex = 32;
            checkBoxLettuce.Text = "Lettuce";
            checkBoxLettuce.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnion
            // 
            checkBoxOnion.AutoSize = true;
            checkBoxOnion.Location = new Point(275, 232);
            checkBoxOnion.Name = "checkBoxOnion";
            checkBoxOnion.Size = new Size(87, 29);
            checkBoxOnion.TabIndex = 31;
            checkBoxOnion.Text = "Onion";
            checkBoxOnion.UseVisualStyleBackColor = true;
            // 
            // checkBoxTomato
            // 
            checkBoxTomato.AutoSize = true;
            checkBoxTomato.Location = new Point(275, 163);
            checkBoxTomato.Name = "checkBoxTomato";
            checkBoxTomato.Size = new Size(98, 29);
            checkBoxTomato.TabIndex = 30;
            checkBoxTomato.Text = "Tomato";
            checkBoxTomato.UseVisualStyleBackColor = true;
            // 
            // HamburgerUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxBacon);
            Controls.Add(pictureBoxPickles);
            Controls.Add(pictureBoxOnion);
            Controls.Add(pictureBoxTomato);
            Controls.Add(checkBoxBacon);
            Controls.Add(checkBoxPickles);
            Controls.Add(checkBoxLettuce);
            Controls.Add(checkBoxOnion);
            Controls.Add(checkBoxTomato);
            Controls.Add(pictureBoxLettuce);
            Controls.Add(IngredientsLabel);
            Controls.Add(panel1);
            Name = "HamburgerUserControl";
            Size = new Size(384, 390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLettuce).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBacon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOnion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTomato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label HamburgerLabel;
        private Label IngredientsLabel;
        private PictureBox pictureBoxLettuce;
        private PictureBox pictureBoxBacon;
        private PictureBox pictureBoxPickles;
        private PictureBox pictureBoxOnion;
        private PictureBox pictureBoxTomato;
        private CheckBox checkBoxBacon;
        private CheckBox checkBoxPickles;
        private CheckBox checkBoxLettuce;
        private CheckBox checkBoxOnion;
        private CheckBox checkBoxTomato;
    }
}
