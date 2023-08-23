using Menu;
using System;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Project
{
    public partial class BranchesForm : Form
    {
        public Branches currentBranches;
        public int index;
        public event EventHandler<BranchEventArgs> BranchIndexChanged; // Event that tells subscribers that the active index has been changed

        public BranchesForm(Branches branchesList)
        {
            InitializeComponent();
            currentBranches = branchesList;
            index = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshComboBox();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;
            BranchIndexChanged?.Invoke(this, new BranchEventArgs(index));
            // Raise the event to notify the main form about the update
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if ( comboBox1.Text.Length>0)
            {
                currentBranches.AddNewBranch(comboBox1.Text);
                refreshComboBox();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                string temp = currentBranches[index].ToString();
                if (comboBox1.Text.Length > 0)
                {
                    if (currentBranches.FindBranchByName(temp) != null)
                    {
                        currentBranches.RemoveBranch(temp);
                        index = -1;
                        BranchIndexChanged?.Invoke(this, new BranchEventArgs(index));

                    }
                }
            }
            refreshComboBox();
        }

        private void refreshComboBox() // recreates the objects in the combobox
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            int listSize = currentBranches.AmountOfBranches();
            for (int i = 0; i < listSize; i++)
            {
                comboBox1.Items.Add(currentBranches[i]);
            }
        }
    }
}