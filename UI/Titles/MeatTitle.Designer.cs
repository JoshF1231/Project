namespace Project.UI.Titles
{
    partial class MeatTitle
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
            MeatLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(MeatLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 74);
            panel1.TabIndex = 12;
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
            // MeatTitle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MeatTitle";
            Size = new Size(392, 74);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label MeatLabel;
    }
}
