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
            dishesButton = new Button();
            menuButton = new Button();
            Branches = new Button();
            panel2 = new Panel();
            mainpanel = new Panel();
            panel1.SuspendLayout();
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
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(loadButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(dishesButton);
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(Branches);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 557);
            panel1.TabIndex = 10;
            // 
            // loadButton
            // 
            loadButton.BackgroundImageLayout = ImageLayout.None;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Image = Properties.Resources.branches1;
            loadButton.ImageAlign = ContentAlignment.MiddleLeft;
            loadButton.Location = new Point(6, 485);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(185, 51);
            loadButton.TabIndex = 16;
            loadButton.Text = "LOAD";
            loadButton.TextAlign = ContentAlignment.MiddleRight;
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackgroundImageLayout = ImageLayout.None;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Image = Properties.Resources.branches1;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(6, 428);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(185, 51);
            saveButton.TabIndex = 15;
            saveButton.Text = "SAVE";
            saveButton.TextAlign = ContentAlignment.MiddleRight;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dishesButton
            // 
            dishesButton.BackgroundImageLayout = ImageLayout.None;
            dishesButton.FlatStyle = FlatStyle.Flat;
            dishesButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dishesButton.Image = Properties.Resources.test2;
            dishesButton.ImageAlign = ContentAlignment.MiddleLeft;
            dishesButton.Location = new Point(6, 209);
            dishesButton.Name = "dishesButton";
            dishesButton.Size = new Size(185, 51);
            dishesButton.TabIndex = 14;
            dishesButton.Text = "DISHES";
            dishesButton.TextAlign = ContentAlignment.MiddleRight;
            dishesButton.UseVisualStyleBackColor = true;
            dishesButton.Click += dishesButton_Click;
            // 
            // menuButton
            // 
            menuButton.BackgroundImageLayout = ImageLayout.None;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuButton.Image = Properties.Resources.branches1;
            menuButton.ImageAlign = ContentAlignment.MiddleLeft;
            menuButton.Location = new Point(6, 151);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(185, 51);
            menuButton.TabIndex = 13;
            menuButton.Text = "MENU";
            menuButton.TextAlign = ContentAlignment.MiddleRight;
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // Branches
            // 
            Branches.BackgroundImageLayout = ImageLayout.None;
            Branches.FlatStyle = FlatStyle.Flat;
            Branches.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Branches.Image = Properties.Resources.branches1;
            Branches.ImageAlign = ContentAlignment.MiddleLeft;
            Branches.Location = new Point(6, 93);
            Branches.Name = "Branches";
            Branches.Size = new Size(185, 51);
            Branches.TabIndex = 12;
            Branches.Text = "BRANCHES";
            Branches.TextAlign = ContentAlignment.MiddleRight;
            Branches.UseVisualStyleBackColor = true;
            Branches.Click += Branches_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.SlateGray;
            panel2.Location = new Point(-55, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 24);
            panel2.TabIndex = 11;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(200, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(732, 557);
            mainpanel.TabIndex = 12;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(932, 557);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ImageList imageList1;
        private Panel panel1;
        private Panel panel2;
        private Button Branches;
        private Button dishesButton;
        private Button menuButton;
        private Panel mainpanel;
        private Button loadButton;
        private Button saveButton;
    }
}