namespace Project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dishesButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.Branches = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.branchLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 696);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "test box";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.dishesButton);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.Branches);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 761);
            this.panel1.TabIndex = 10;
            // 
            // loadButton
            // 
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Image = global::Project.Properties.Resources.branches1;
            this.loadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadButton.Location = new System.Drawing.Point(3, 692);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(222, 68);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Load";
            this.loadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Image = global::Project.Properties.Resources.branches1;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(3, 625);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(222, 68);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // dishesButton
            // 
            this.dishesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dishesButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.dishesButton.FlatAppearance.BorderSize = 0;
            this.dishesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishesButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dishesButton.Image = global::Project.Properties.Resources.test2;
            this.dishesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dishesButton.Location = new System.Drawing.Point(3, 180);
            this.dishesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dishesButton.Name = "dishesButton";
            this.dishesButton.Size = new System.Drawing.Size(222, 68);
            this.dishesButton.TabIndex = 14;
            this.dishesButton.Text = "Dishes";
            this.dishesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dishesButton.UseVisualStyleBackColor = true;
            // 
            // menuButton
            // 
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuButton.Image = global::Project.Properties.Resources.branches1;
            this.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.Location = new System.Drawing.Point(3, 113);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(222, 68);
            this.menuButton.TabIndex = 13;
            this.menuButton.Text = "Menu";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuButton.UseVisualStyleBackColor = true;
            // 
            // Branches
            // 
            this.Branches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Branches.FlatAppearance.BorderSize = 0;
            this.Branches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Branches.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Branches.Image = global::Project.Properties.Resources.branches1;
            this.Branches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Branches.Location = new System.Drawing.Point(3, 47);
            this.Branches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(222, 68);
            this.Branches.TabIndex = 12;
            this.Branches.Text = "Branches";
            this.Branches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Branches.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.topPanel.Controls.Add(this.branchLabel);
            this.topPanel.Controls.Add(this.headerLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1081, 47);
            this.topPanel.TabIndex = 11;
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.branchLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.branchLabel.Location = new System.Drawing.Point(215, 9);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.branchLabel.Size = new System.Drawing.Size(59, 24);
            this.branchLabel.TabIndex = 1;
            this.branchLabel.Text = "None";
            this.branchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(6, 11);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(211, 24);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "SELECTED BRANCH:";
            // 
            // mainpanel
            // 
            this.mainpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainpanel.BackColor = System.Drawing.Color.Silver;
            this.mainpanel.Location = new System.Drawing.Point(225, 37);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(857, 724);
            this.mainpanel.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1081, 761);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mainpanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private ImageList imageList1;
        private Panel panel1;
        private Panel topPanel;
        private Button Branches;
        private Button dishesButton;
        private Button menuButton;
        private Panel mainpanel;
        private Button loadButton;
        private Button saveButton;
        private Label branchLabel;
        private Label headerLabel;
    }
}