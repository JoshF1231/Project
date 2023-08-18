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
            meatMenu = new TreeView();
            dairyMenu = new TreeView();
            meatLabel = new Label();
            dairyLabel = new Label();
            label1 = new Label();
            currBranchLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // meatMenu
            // 
            meatMenu.BackColor = Color.Silver;
            meatMenu.BorderStyle = BorderStyle.None;
            meatMenu.Location = new Point(63, 156);
            meatMenu.Name = "meatMenu";
            meatMenu.Size = new Size(405, 452);
            meatMenu.TabIndex = 0;
            // 
            // dairyMenu
            // 
            dairyMenu.BackColor = Color.Silver;
            dairyMenu.BorderStyle = BorderStyle.None;
            dairyMenu.Location = new Point(563, 156);
            dairyMenu.Name = "dairyMenu";
            dairyMenu.Size = new Size(405, 452);
            dairyMenu.TabIndex = 1;
            // 
            // meatLabel
            // 
            meatLabel.AutoSize = true;
            meatLabel.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            meatLabel.Location = new Point(137, 104);
            meatLabel.Name = "meatLabel";
            meatLabel.Size = new Size(233, 42);
            meatLabel.TabIndex = 2;
            meatLabel.Text = "FRESH MEAT";
            // 
            // dairyLabel
            // 
            dairyLabel.AutoSize = true;
            dairyLabel.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            dairyLabel.Location = new Point(706, 104);
            dairyLabel.Name = "dairyLabel";
            dairyLabel.Size = new Size(120, 42);
            dairyLabel.TabIndex = 3;
            dairyLabel.Text = "DAIRY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 28);
            label1.Name = "label1";
            label1.Size = new Size(93, 27);
            label1.TabIndex = 4;
            label1.Text = "Branch:";
            // 
            // currBranchLabel
            // 
            currBranchLabel.AutoSize = true;
            currBranchLabel.Location = new Point(162, 37);
            currBranchLabel.Name = "currBranchLabel";
            currBranchLabel.Size = new Size(38, 15);
            currBranchLabel.TabIndex = 5;
            currBranchLabel.Text = "label2";
            // 
            // backButton
            // 
            backButton.Image = Properties.Resources.back_button_small;
            backButton.ImageAlign = ContentAlignment.BottomRight;
            backButton.Location = new Point(12, 593);
            backButton.Name = "backButton";
            backButton.RightToLeft = RightToLeft.No;
            backButton.Size = new Size(33, 33);
            backButton.TabIndex = 6;
            backButton.UseVisualStyleBackColor = true;
            // 
            // Menu_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 638);
            Controls.Add(backButton);
            Controls.Add(currBranchLabel);
            Controls.Add(label1);
            Controls.Add(dairyLabel);
            Controls.Add(meatLabel);
            Controls.Add(dairyMenu);
            Controls.Add(meatMenu);
            Name = "Menu_Form";
            Text = "Menu_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView meatMenu;
        private TreeView dairyMenu;
        private Label meatLabel;
        private Label dairyLabel;
        private Label label1;
        private Label currBranchLabel;
        private Button backButton;
    }
}