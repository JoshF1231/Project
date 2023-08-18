using Menu;
using System;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace Project
{

    public partial class BranchesForm : Form
    {
        static Branches currentBranches;
        BindingSource branchesBindingSource = new BindingSource();
        public BranchesForm()
        {
            InitializeComponent();
            currentBranches = new Branches();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load branches list from file
            // bind the branches list to the combo box (comboBox1)
            //branchesBindingSource.DataSource = currentBranches;
            //comboBox1.DataSource= branchesBindingSource; 
            refreshComboBox();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
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
                string temp = currentBranches[index].ToString();
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

        private void refreshComboBox() // recreates the objects in the combobox
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
            // load from file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "branch files (*.brc)| *.brc| All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                currentBranches = (Branches)binaryFormatter.Deserialize(stream);
                stream.Close();
            }
            refreshComboBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // save to file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "branch files (*.brc)| *.brc| All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    formatter.Serialize(stream, currentBranches);
                    stream.Close();

                }

            }
            refreshComboBox();

        }
    }
}