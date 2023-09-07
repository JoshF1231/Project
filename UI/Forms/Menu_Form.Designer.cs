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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            addButton = new Button();
            removeButton = new Button();
            warning = new Label();
            menuDataGrid = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            selectedImage = new DataGridViewImageColumn();
            branchBindingSource = new BindingSource(components);
            menuLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)menuDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)branchBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(654, 69);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(654, 98);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 5;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.BackColor = Color.LightSteelBlue;
            warning.ForeColor = Color.IndianRed;
            warning.Location = new Point(617, 45);
            warning.Name = "warning";
            warning.Size = new Size(110, 15);
            warning.TabIndex = 8;
            warning.Text = "Select a branch first";
            warning.Visible = false;
            // 
            // menuDataGrid
            // 
            menuDataGrid.AllowUserToAddRows = false;
            menuDataGrid.AllowUserToDeleteRows = false;
            menuDataGrid.AllowUserToResizeColumns = false;
            menuDataGrid.AllowUserToResizeRows = false;
            menuDataGrid.AutoGenerateColumns = false;
            menuDataGrid.BorderStyle = BorderStyle.None;
            menuDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            menuDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuDataGrid.Columns.AddRange(new DataGridViewColumn[] { name, priceDataGridViewTextBoxColumn, Weight, selectedImage });
            menuDataGrid.DataSource = branchBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            menuDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            menuDataGrid.Location = new Point(12, 69);
            menuDataGrid.Name = "menuDataGrid";
            menuDataGrid.ReadOnly = true;
            menuDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            menuDataGrid.RowHeadersVisible = false;
            menuDataGrid.RowHeadersWidth = 51;
            menuDataGrid.RowTemplate.Height = 25;
            menuDataGrid.Size = new Size(624, 421);
            menuDataGrid.TabIndex = 9;
            menuDataGrid.CellDoubleClick += menuDataGrid_CellDoubleClick;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Weight
            // 
            Weight.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Weight.DataPropertyName = "Weight";
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // selectedImage
            // 
            selectedImage.DataPropertyName = "selectedImage";
            selectedImage.HeaderText = "Image";
            selectedImage.Name = "selectedImage";
            selectedImage.ReadOnly = true;
            // 
            // branchBindingSource
            // 
            branchBindingSource.DataMember = "Menu";
            branchBindingSource.DataSource = typeof(Menu.Branch);
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Location = new Point(56, 31);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(0, 15);
            menuLabel.TabIndex = 10;
            // 
            // Menu_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(750, 496);
            ControlBox = false;
            Controls.Add(menuLabel);
            Controls.Add(menuDataGrid);
            Controls.Add(warning);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Menu_Form";
            Text = "Menu_Form";
            ((System.ComponentModel.ISupportInitialize)menuDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)branchBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addButton;
        private Button removeButton;
        private Label warning;
        private DataGridView menuDataGrid;
        private Label menuLabel;
        private BindingSource branchBindingSource;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn showItemDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isVeganDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewImageColumn selectedImage;
    }
}