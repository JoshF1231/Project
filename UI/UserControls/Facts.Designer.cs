namespace Project.UI.UserControls
{
    partial class Facts
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
            FactsLabel = new Label();
            richTextBoxFacts = new RichTextBox();
            SuspendLayout();
            // 
            // FactsLabel
            // 
            FactsLabel.AutoSize = true;
            FactsLabel.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            FactsLabel.Location = new Point(59, 12);
            FactsLabel.Name = "FactsLabel";
            FactsLabel.Size = new Size(269, 89);
            FactsLabel.TabIndex = 5;
            FactsLabel.Text = "FACTS:";
            // 
            // richTextBoxFacts
            // 
            richTextBoxFacts.Location = new Point(31, 117);
            richTextBoxFacts.Name = "richTextBoxFacts";
            richTextBoxFacts.Size = new Size(336, 157);
            richTextBoxFacts.TabIndex = 8;
            richTextBoxFacts.Text = "";
            // 
            // Facts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBoxFacts);
            Controls.Add(FactsLabel);
            Name = "Facts";
            Size = new Size(389, 298);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FactsLabel;
        private RichTextBox richTextBoxFacts;
    }
}
