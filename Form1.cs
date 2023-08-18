using Menu;
using System;
using System.Collections.Specialized;

namespace Project
{

    public partial class Form1 : Form
    {
        Branches currentBranches;
        public Form1()
        {
            InitializeComponent();
            currentBranches = new Branches();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshComboBox();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            textBox1.Text = textFromBoxByIndex(index);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            currentBranches.AddNewBranch(comboBox1.Text);
            comboBox1.Text = "";
            refreshComboBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index >= 0)
            {
                string temp = textFromBoxByIndex(index);
                if (comboBox1.Text.Length > 0)
                {
                    if (currentBranches.FindBranchByName(temp) != null)
                    {
                        currentBranches.RemoveBranch(temp);
                    }
                }
            }
            comboBox1.Text = "";
            refreshComboBox();
        }
        private string textFromBoxByIndex(int index)
        {
            string result = "";
            if (currentBranches[index] != null)
                result = currentBranches[index].ToString();
            return result;
        }
        private void refreshComboBox()
        {
            comboBox1.Items.Clear();
            int listSize = currentBranches.AmountOfBranches();
            for (int i = 0; i < listSize; i++)
            {
                comboBox1.Items.Add(currentBranches[i].ToString());
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}