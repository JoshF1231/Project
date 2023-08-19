namespace Project
{
    partial class DairyListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DairyListControl));
            panel1 = new Panel();
            HomeButton = new Button();
            DairyButton = new Button();
            PizzaButton = new Button();
            PastaButton = new Button();
            IceCreamButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(IceCreamButton);
            panel1.Controls.Add(PastaButton);
            panel1.Controls.Add(HomeButton);
            panel1.Controls.Add(PizzaButton);
            panel1.Controls.Add(DairyButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 713);
            panel1.TabIndex = 2;
            // 
            // HomeButton
            // 
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("David", 16F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton.ForeColor = Color.White;
            HomeButton.Location = new Point(0, 30);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(204, 77);
            HomeButton.TabIndex = 5;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            // 
            // DairyButton
            // 
            DairyButton.FlatAppearance.BorderSize = 0;
            DairyButton.FlatStyle = FlatStyle.Flat;
            DairyButton.Font = new Font("David", 16F, FontStyle.Regular, GraphicsUnit.Point);
            DairyButton.ForeColor = Color.White;
            DairyButton.Location = new Point(0, 113);
            DairyButton.Name = "DairyButton";
            DairyButton.Size = new Size(204, 77);
            DairyButton.TabIndex = 3;
            DairyButton.Text = "Dairy";
            DairyButton.UseVisualStyleBackColor = true;
            // 
            // PizzaButton
            // 
            PizzaButton.FlatAppearance.BorderSize = 0;
            PizzaButton.FlatStyle = FlatStyle.Flat;
            PizzaButton.Font = new Font("David", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PizzaButton.ForeColor = Color.White;
            PizzaButton.Image = (Image)resources.GetObject("PizzaButton.Image");
            PizzaButton.ImageAlign = ContentAlignment.MiddleLeft;
            PizzaButton.Location = new Point(0, 196);
            PizzaButton.Name = "PizzaButton";
            PizzaButton.Size = new Size(204, 35);
            PizzaButton.TabIndex = 4;
            PizzaButton.Text = "Pizza";
            PizzaButton.UseVisualStyleBackColor = true;
            // 
            // PastaButton
            // 
            PastaButton.FlatAppearance.BorderSize = 0;
            PastaButton.FlatStyle = FlatStyle.Flat;
            PastaButton.Font = new Font("David", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PastaButton.ForeColor = Color.White;
            PastaButton.Image = (Image)resources.GetObject("PastaButton.Image");
            PastaButton.ImageAlign = ContentAlignment.MiddleLeft;
            PastaButton.Location = new Point(0, 237);
            PastaButton.Name = "PastaButton";
            PastaButton.Size = new Size(204, 35);
            PastaButton.TabIndex = 5;
            PastaButton.Text = "Pasta";
            PastaButton.UseVisualStyleBackColor = true;
            // 
            // IceCreamButton
            // 
            IceCreamButton.FlatAppearance.BorderSize = 0;
            IceCreamButton.FlatStyle = FlatStyle.Flat;
            IceCreamButton.Font = new Font("David", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IceCreamButton.ForeColor = Color.White;
            IceCreamButton.Image = (Image)resources.GetObject("IceCreamButton.Image");
            IceCreamButton.ImageAlign = ContentAlignment.MiddleLeft;
            IceCreamButton.Location = new Point(0, 278);
            IceCreamButton.Name = "IceCreamButton";
            IceCreamButton.Size = new Size(204, 35);
            IceCreamButton.TabIndex = 6;
            IceCreamButton.Text = "IceCream";
            IceCreamButton.UseVisualStyleBackColor = true;
            // 
            // DairyListControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "DairyListControl";
            Size = new Size(1411, 713);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button HomeButton;
        private Button PizzaButton;
        private Button DairyButton;
        private Button IceCreamButton;
        private Button PastaButton;
    }
}
