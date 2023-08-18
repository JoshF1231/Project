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
            textBox1.Text = textFromBox(index);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            currentBranches.AddNewBranch(comboBox1.Text);
            refreshComboBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index < currentBranches.AmountOfBranches())
            {
                currentBranches.RemoveBranch(index);
            }
            refreshComboBox();
        }
        private string textFromBox(int index)
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
            currentBranches.RemoveBranch(textFromBox(1));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}