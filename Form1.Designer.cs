﻿namespace Project
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            createButton = new Button();
            loadButton = new Button();
            deleteButton = new Button();
            textBox1 = new TextBox();
            test2 = new TextBox();
            saveButton = new Button();
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(379, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // createButton
            // 
            createButton.Location = new Point(581, 235);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 3;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(581, 293);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 4;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(581, 264);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 522);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "test box";
            // 
            // test2
            // 
            test2.Location = new Point(12, 236);
            test2.Name = "test2";
            test2.Size = new Size(100, 23);
            test2.TabIndex = 7;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(581, 322);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 557);
            Controls.Add(saveButton);
            Controls.Add(test2);
            Controls.Add(textBox1);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(createButton);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private Button createButton;
        private Button loadButton;
        private Button deleteButton;
        private TextBox textBox1;
        private TextBox test2;
        private Button saveButton;
    }
}