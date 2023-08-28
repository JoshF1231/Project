namespace Project
{
    partial class DishesForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishesForm));
            Temporary = new Label();
            panel1 = new Panel();
            DairyPanelButton = new Button();
            MeatBasedPanelButton = new Button();
            dishesListBox = new ListBox();
            tempLabel = new Label();
            panel2 = new Panel();
            pictureBoxDishes = new PictureBox();
            PanelUserControl = new Panel();
            AddButton = new Button();
            FactsLabel = new Label();
            richTextBoxFacts = new RichTextBox();
            TitlePanel = new Panel();
            TypeLabel = new Label();
            TypeBox = new ComboBox();
            PanelIngredients = new Panel();
            imageListDishes = new ImageList(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDishes).BeginInit();
            PanelUserControl.SuspendLayout();
            SuspendLayout();
            // 
            // Temporary
            // 
            Temporary.AutoSize = true;
            Temporary.Font = new Font("David", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Temporary.Location = new Point(220, 19);
            Temporary.Margin = new Padding(4, 0, 4, 0);
            Temporary.Name = "Temporary";
            Temporary.Size = new Size(502, 71);
            Temporary.TabIndex = 0;
            Temporary.Text = "DISHES FORM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(DairyPanelButton);
            panel1.Controls.Add(MeatBasedPanelButton);
            panel1.Controls.Add(dishesListBox);
            panel1.Controls.Add(tempLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 750);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // DairyPanelButton
            // 
            DairyPanelButton.FlatAppearance.BorderSize = 0;
            DairyPanelButton.FlatStyle = FlatStyle.Flat;
            DairyPanelButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DairyPanelButton.ForeColor = Color.White;
            DairyPanelButton.Location = new Point(0, 96);
            DairyPanelButton.Name = "DairyPanelButton";
            DairyPanelButton.Size = new Size(204, 77);
            DairyPanelButton.TabIndex = 9;
            DairyPanelButton.Text = "Dairy";
            DairyPanelButton.UseVisualStyleBackColor = true;
            DairyPanelButton.Click += DairyPanelButton_Click;
            // 
            // MeatBasedPanelButton
            // 
            MeatBasedPanelButton.FlatAppearance.BorderSize = 0;
            MeatBasedPanelButton.FlatStyle = FlatStyle.Flat;
            MeatBasedPanelButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MeatBasedPanelButton.ForeColor = Color.White;
            MeatBasedPanelButton.Location = new Point(0, 3);
            MeatBasedPanelButton.Name = "MeatBasedPanelButton";
            MeatBasedPanelButton.Size = new Size(204, 77);
            MeatBasedPanelButton.TabIndex = 8;
            MeatBasedPanelButton.Text = "MeatBased";
            MeatBasedPanelButton.UseVisualStyleBackColor = true;
            MeatBasedPanelButton.Click += MeatBasedPanelButton_Click;
            // 
            // dishesListBox
            // 
            dishesListBox.FormattingEnabled = true;
            dishesListBox.ItemHeight = 25;
            dishesListBox.Location = new Point(17, 323);
            dishesListBox.Margin = new Padding(4, 5, 4, 5);
            dishesListBox.Name = "dishesListBox";
            dishesListBox.Size = new Size(170, 329);
            dishesListBox.TabIndex = 7;
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Location = new Point(27, 290);
            tempLabel.Margin = new Padding(4, 0, 4, 0);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(76, 25);
            tempLabel.TabIndex = 6;
            tempLabel.Text = "DISHES:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBoxDishes);
            panel2.Controls.Add(Temporary);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(204, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 107);
            panel2.TabIndex = 2;
            // 
            // pictureBoxDishes
            // 
            pictureBoxDishes.Location = new Point(26, 3);
            pictureBoxDishes.Name = "pictureBoxDishes";
            pictureBoxDishes.Size = new Size(100, 100);
            pictureBoxDishes.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxDishes.TabIndex = 1;
            pictureBoxDishes.TabStop = false;
            // 
            // PanelUserControl
            // 
            PanelUserControl.BackColor = Color.Gray;
            PanelUserControl.Controls.Add(AddButton);
            PanelUserControl.Location = new Point(226, 256);
            PanelUserControl.Name = "PanelUserControl";
            PanelUserControl.Size = new Size(400, 350);
            PanelUserControl.TabIndex = 3;
            PanelUserControl.Paint += PanelUserControl_Paint;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(35, 536);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // FactsLabel
            // 
            FactsLabel.AutoSize = true;
            FactsLabel.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            FactsLabel.Location = new Point(728, 488);
            FactsLabel.Name = "FactsLabel";
            FactsLabel.Size = new Size(269, 89);
            FactsLabel.TabIndex = 4;
            FactsLabel.Text = "FACTS:";
            // 
            // richTextBoxFacts
            // 
            richTextBoxFacts.Location = new Point(697, 571);
            richTextBoxFacts.Name = "richTextBoxFacts";
            richTextBoxFacts.Size = new Size(336, 157);
            richTextBoxFacts.TabIndex = 7;
            richTextBoxFacts.Text = "";
            // 
            // TitlePanel
            // 
            TitlePanel.Location = new Point(227, 117);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(392, 74);
            TitlePanel.TabIndex = 27;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeLabel.Location = new Point(261, 212);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(69, 24);
            TypeLabel.TabIndex = 31;
            TypeLabel.Text = "Type:";
            // 
            // TypeBox
            // 
            TypeBox.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeBox.FormattingEnabled = true;
            TypeBox.Location = new Point(349, 209);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(150, 32);
            TypeBox.TabIndex = 32;
            TypeBox.SelectedIndexChanged += TypeBox_SelectedIndexChanged;
            // 
            // PanelIngredients
            // 
            PanelIngredients.BackColor = Color.Gray;
            PanelIngredients.Location = new Point(684, 117);
            PanelIngredients.Name = "PanelIngredients";
            PanelIngredients.Size = new Size(370, 375);
            PanelIngredients.TabIndex = 33;
            // 
            // imageListDishes
            // 
            imageListDishes.ColorDepth = ColorDepth.Depth32Bit;
            imageListDishes.ImageStream = (ImageListStreamer)resources.GetObject("imageListDishes.ImageStream");
            imageListDishes.TransparentColor = Color.Transparent;
            imageListDishes.Images.SetKeyName(0, "BurgerIcon.png");
            imageListDishes.Images.SetKeyName(1, "icons8-pasta-100.png");
            // 
            // DishesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 750);
            Controls.Add(PanelIngredients);
            Controls.Add(richTextBoxFacts);
            Controls.Add(TypeBox);
            Controls.Add(FactsLabel);
            Controls.Add(TypeLabel);
            Controls.Add(TitlePanel);
            Controls.Add(PanelUserControl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "DishesForm";
            Text = "DishesForm";
            Load += DishesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDishes).EndInit();
            PanelUserControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Temporary;
        private Panel panel1;
        private Panel panel2;
        private Label tempLabel;
        private ListBox dishesListBox;
        private Button MeatBasedPanelButton;
        private Button DairyPanelButton;
        private Panel PanelUserControl;
        private Label FactsLabel;
        private RichTextBox richTextBoxFacts;
        private Button AddButton;
        private Panel TitlePanel;
        private Label TypeLabel;
        private ComboBox TypeBox;
        private Panel PanelIngredients;
        private ImageList imageListDishes;
        private PictureBox pictureBoxDishes;
    }
}