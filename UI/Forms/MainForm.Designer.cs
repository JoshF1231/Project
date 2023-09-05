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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            loadButton = new Button();
            saveButton = new Button();
            menuButton = new Button();
            Branches = new Button();
            topPanel = new Panel();
            branchLabel = new Label();
            headerLabel = new Label();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 522);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "test box";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(loadButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(Branches);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 571);
            panel1.TabIndex = 10;
            // 
            // loadButton
            // 
            loadButton.BackgroundImageLayout = ImageLayout.None;
            loadButton.FlatAppearance.BorderSize = 0;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Image = Properties.Resources.branches1;
            loadButton.ImageAlign = ContentAlignment.MiddleLeft;
            loadButton.Location = new Point(3, 519);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(194, 51);
            loadButton.TabIndex = 16;
            loadButton.Text = "Load";
            loadButton.TextAlign = ContentAlignment.MiddleRight;
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackgroundImageLayout = ImageLayout.None;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Image = Properties.Resources.branches1;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(3, 469);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(194, 51);
            saveButton.TabIndex = 15;
            saveButton.Text = "Save";
            saveButton.TextAlign = ContentAlignment.MiddleRight;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // menuButton
            // 
            menuButton.BackgroundImageLayout = ImageLayout.None;
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuButton.Image = Properties.Resources.branches1;
            menuButton.ImageAlign = ContentAlignment.MiddleLeft;
            menuButton.Location = new Point(3, 85);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(194, 51);
            menuButton.TabIndex = 13;
            menuButton.Text = "Menu";
            menuButton.TextAlign = ContentAlignment.MiddleRight;
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // Branches
            // 
            Branches.BackgroundImageLayout = ImageLayout.None;
            Branches.FlatAppearance.BorderSize = 0;
            Branches.FlatStyle = FlatStyle.Flat;
            Branches.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Branches.Image = Properties.Resources.branches1;
            Branches.ImageAlign = ContentAlignment.MiddleLeft;
            Branches.Location = new Point(3, 35);
            Branches.Name = "Branches";
            Branches.Size = new Size(194, 51);
            Branches.TabIndex = 12;
            Branches.Text = "Branches";
            Branches.TextAlign = ContentAlignment.MiddleRight;
            Branches.UseVisualStyleBackColor = true;
            Branches.Click += Branches_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.AliceBlue;
            topPanel.Controls.Add(branchLabel);
            topPanel.Controls.Add(headerLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(946, 35);
            topPanel.TabIndex = 11;
            // 
            // branchLabel
            // 
            branchLabel.AutoSize = true;
            branchLabel.BackColor = Color.LightSlateGray;
            branchLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            branchLabel.Location = new Point(188, 7);
            branchLabel.Name = "branchLabel";
            branchLabel.RightToLeft = RightToLeft.No;
            branchLabel.Size = new Size(50, 19);
            branchLabel.TabIndex = 1;
            branchLabel.Text = "None";
            branchLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(5, 8);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(178, 19);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "SELECTED BRANCH:";
            // 
            // mainpanel
            // 
            mainpanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainpanel.BackColor = Color.Silver;
            mainpanel.Location = new Point(197, 28);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(750, 543);
            mainpanel.TabIndex = 12;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(946, 571);
            Controls.Add(topPanel);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(mainpanel);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ImageList imageList1;
        private Panel panel1;
        private Panel topPanel;
        private Button Branches;
        private Button menuButton;
        private Panel mainpanel;
        private Button loadButton;
        private Button saveButton;
        private Label branchLabel;
        private Label headerLabel;
    }
}