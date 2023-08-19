namespace Project
{
    partial class Menu_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Temporary = new Label();
            test = new TextBox();
            SuspendLayout();
            // 
            // Temporary
            // 
            Temporary.AutoSize = true;
            Temporary.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Temporary.Location = new Point(275, 190);
            Temporary.Name = "Temporary";
            Temporary.Size = new Size(158, 27);
            Temporary.TabIndex = 1;
            Temporary.Text = "MENU FORM";
            // 
            // test
            // 
            test.Location = new Point(314, 312);
            test.Name = "test";
            test.Size = new Size(100, 23);
            test.TabIndex = 2;
            test.Click += test_Click;
            // 
            // Menu_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(797, 496);
            ControlBox = false;
            Controls.Add(test);
            Controls.Add(Temporary);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Menu_Form";
            Text = "Menu_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Temporary;
        private TextBox test;
    }
}