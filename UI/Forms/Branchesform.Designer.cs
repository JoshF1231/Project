namespace Project
{
    partial class BranchesForm
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            createButton = new Button();
            deleteButton = new Button();
            imageList1 = new ImageList(components);
            MeatBasedPanelButton = new Button();
            DairyPanelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(344, 338);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 33);
            label1.TabIndex = 1;
            label1.Text = "Select a branch:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 403);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // createButton
            // 
            createButton.Location = new Point(627, 403);
            createButton.Margin = new Padding(4, 5, 4, 5);
            createButton.Name = "createButton";
            createButton.Size = new Size(107, 38);
            createButton.TabIndex = 3;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(627, 452);
            deleteButton.Margin = new Padding(4, 5, 4, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(107, 38);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // MeatBasedPanelButton
            // 
            MeatBasedPanelButton.FlatAppearance.BorderSize = 0;
            MeatBasedPanelButton.FlatStyle = FlatStyle.Flat;
            MeatBasedPanelButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MeatBasedPanelButton.ForeColor = Color.White;
            MeatBasedPanelButton.Location = new Point(840, 294);
            MeatBasedPanelButton.Name = "MeatBasedPanelButton";
            MeatBasedPanelButton.Size = new Size(204, 77);
            MeatBasedPanelButton.TabIndex = 6;
            MeatBasedPanelButton.Text = "MeatBased";
            MeatBasedPanelButton.UseVisualStyleBackColor = true;
            // 
            // DairyPanelButton
            // 
            DairyPanelButton.FlatAppearance.BorderSize = 0;
            DairyPanelButton.FlatStyle = FlatStyle.Flat;
            DairyPanelButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DairyPanelButton.ForeColor = Color.White;
            DairyPanelButton.Location = new Point(840, 377);
            DairyPanelButton.Name = "DairyPanelButton";
            DairyPanelButton.Size = new Size(204, 77);
            DairyPanelButton.TabIndex = 7;
            DairyPanelButton.Text = "Dairy";
            DairyPanelButton.UseVisualStyleBackColor = true;
            // 
            // BranchesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1331, 928);
            Controls.Add(DairyPanelButton);
            Controls.Add(MeatBasedPanelButton);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "BranchesForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private Button createButton;
        private Button deleteButton;
        private ImageList imageList1;
        private Button MeatBasedPanelButton;
        private Button DairyPanelButton;
    }
}