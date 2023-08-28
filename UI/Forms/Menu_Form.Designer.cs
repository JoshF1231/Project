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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.menuDataGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showItemDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isVeganDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(747, 92);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 31);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(747, 131);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(86, 31);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.BackColor = System.Drawing.Color.White;
            this.warning.ForeColor = System.Drawing.Color.IndianRed;
            this.warning.Location = new System.Drawing.Point(747, 57);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(139, 20);
            this.warning.TabIndex = 8;
            this.warning.Text = "Select a branch first";
            this.warning.Visible = false;
            // 
            // menuDataGrid
            // 
            this.menuDataGrid.AllowUserToAddRows = false;
            this.menuDataGrid.AllowUserToDeleteRows = false;
            this.menuDataGrid.AutoGenerateColumns = false;
            this.menuDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.menuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.priceDataGridViewTextBoxColumn,
            this.showItemDataGridViewCheckBoxColumn,
            this.isVeganDataGridViewCheckBoxColumn});
            this.menuDataGrid.DataSource = this.branchBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.menuDataGrid.Location = new System.Drawing.Point(14, 92);
            this.menuDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuDataGrid.Name = "menuDataGrid";
            this.menuDataGrid.ReadOnly = true;
            this.menuDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.menuDataGrid.RowHeadersVisible = false;
            this.menuDataGrid.RowHeadersWidth = 51;
            this.menuDataGrid.RowTemplate.Height = 25;
            this.menuDataGrid.Size = new System.Drawing.Size(713, 561);
            this.menuDataGrid.TabIndex = 9;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // showItemDataGridViewCheckBoxColumn
            // 
            this.showItemDataGridViewCheckBoxColumn.DataPropertyName = "showItem";
            this.showItemDataGridViewCheckBoxColumn.HeaderText = "Enabled";
            this.showItemDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.showItemDataGridViewCheckBoxColumn.Name = "showItemDataGridViewCheckBoxColumn";
            this.showItemDataGridViewCheckBoxColumn.ReadOnly = true;
            this.showItemDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isVeganDataGridViewCheckBoxColumn
            // 
            this.isVeganDataGridViewCheckBoxColumn.DataPropertyName = "isVegan";
            this.isVeganDataGridViewCheckBoxColumn.HeaderText = "Vegan";
            this.isVeganDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isVeganDataGridViewCheckBoxColumn.Name = "isVeganDataGridViewCheckBoxColumn";
            this.isVeganDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isVeganDataGridViewCheckBoxColumn.Width = 125;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Menu";
            this.branchBindingSource.DataSource = typeof(Menu.Branch);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(64, 41);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(0, 20);
            this.menuLabel.TabIndex = 10;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(911, 661);
            this.ControlBox = false;
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.menuDataGrid);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu_Form";
            this.Text = "Menu_Form";
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addButton;
        private Button removeButton;
        private Label warning;
        private DataGridView menuDataGrid;
        private Label menuLabel;
        private BindingSource branchBindingSource;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn showItemDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isVeganDataGridViewCheckBoxColumn;
    }
}