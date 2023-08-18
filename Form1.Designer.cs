namespace Project
{
    partial class Form1
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
            branchBindingSource = new BindingSource(components);
            branchesBindingSource2 = new BindingSource(components);
            branchesBindingSource = new BindingSource(components);
            branchesBindingSource1 = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)branchBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)branchesBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)branchesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)branchesBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(379, 196);
            label1.Name = "label1";
            label1.Size = new Size(146, 22);
            label1.TabIndex = 1;
            label1.Text = "Select a branch:";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = branchBindingSource;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(379, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // branchBindingSource
            // 
            branchBindingSource.DataSource = typeof(Menu.Branch);
            // 
            // branchesBindingSource2
            // 
            branchesBindingSource2.DataSource = typeof(Menu.Branches);
            // 
            // branchesBindingSource
            // 
            branchesBindingSource.DataSource = typeof(Menu.Branches);
            // 
            // branchesBindingSource1
            // 
            branchesBindingSource1.DataSource = typeof(Menu.Branches);
            // 
            // button1
            // 
            button1.Location = new Point(581, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(581, 264);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(581, 293);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 557);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)branchBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)branchesBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)branchesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)branchesBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private BindingSource branchesBindingSource1;
        private BindingSource branchesBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
        private BindingSource branchesBindingSource2;
        private BindingSource branchBindingSource;
        private TextBox textBox1;
    }
}