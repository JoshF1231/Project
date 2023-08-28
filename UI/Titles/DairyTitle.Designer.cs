namespace Project.UI.Titles
{
    partial class DairyTitle
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
            panel1.TabIndex = 13;
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
            // DairyTitle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "DairyTitle";
            Size = new Size(392, 74);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label DairyLabel;
    }
}
