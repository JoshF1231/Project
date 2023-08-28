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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            addButton = new Button();
            removeButton = new Button();
            warning = new Label();
            menuDataGrid = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            branchBindingSource = new BindingSource(components);
            menuLabel = new Label();
            isVeganDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            showItemDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            warning.BackColor = Color.White;
            warning.ForeColor = Color.IndianRed;
            warning.Location = new Point(654, 43);
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
            menuDataGrid.AutoGenerateColumns = false;
            menuDataGrid.BorderStyle = BorderStyle.None;
            menuDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            menuDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuDataGrid.Columns.AddRange(new DataGridViewColumn[] { name, Type, isVeganDataGridViewCheckBoxColumn, nameDataGridViewTextBoxColumn, showItemDataGridViewCheckBoxColumn, priceDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn });
            menuDataGrid.DataSource = branchBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            menuDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            menuDataGrid.Location = new Point(12, 69);
            menuDataGrid.Name = "menuDataGrid";
            menuDataGrid.ReadOnly = true;
            menuDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            menuDataGrid.RowTemplate.Height = 25;
            menuDataGrid.Size = new Size(624, 421);
            menuDataGrid.TabIndex = 9;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
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
            // isVeganDataGridViewCheckBoxColumn
            // 
            isVeganDataGridViewCheckBoxColumn.DataPropertyName = "isVegan";
            isVeganDataGridViewCheckBoxColumn.HeaderText = "isVegan";
            isVeganDataGridViewCheckBoxColumn.Name = "isVeganDataGridViewCheckBoxColumn";
            isVeganDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showItemDataGridViewCheckBoxColumn
            // 
            showItemDataGridViewCheckBoxColumn.DataPropertyName = "showItem";
            showItemDataGridViewCheckBoxColumn.HeaderText = "showItem";
            showItemDataGridViewCheckBoxColumn.Name = "showItemDataGridViewCheckBoxColumn";
            showItemDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Menu_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(797, 496);
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
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isVeganDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn showItemDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    }
}