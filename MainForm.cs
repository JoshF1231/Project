using Menu;
using System;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace Project
{

    public partial class MainForm : Form
    {
        public Branches? branchesList { get; set; }
        public MainForm()
        {
            branchesList = new Branches();
            InitializeComponent();
        }

        public void loadform(object Form) // to be replaced with a specific function for each form
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void OpenBranchesForm()
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            if (branchesList == null)
            {
                branchesList = new Branches();
            }
            BranchesForm f = new BranchesForm(branchesList);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            // Subscribe to the event in the sub-form
            f.BranchIndexChanged += BranchesForm_BranchUpdated;

            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void OpenMenuForm()
        {

            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            Menu_Form f;
            if (branchesList.branchesListIndex >= 0)
            {
                f = new Menu_Form(branchesList[branchesList.branchesListIndex]);

            }
            else
            {
                f = new Menu_Form();
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void BranchesForm_BranchUpdated(object sender, BranchEventArgs e)
        {
            // Update the main form based on the changes made in the sub-form
            branchesList.branchesListIndex = e.BranchIndex;
            // Update UI elements or perform any necessary actions
        }

        private void Branches_Click(object sender, EventArgs e)
        {
            OpenBranchesForm();
        }

        private void dishesButton_Click(object sender, EventArgs e)
        {
            loadform(new DishesForm()); // needs to be modified to be similar to menu and branches
            // needs to be sent with DishesForm f = new DishesForm(mainDish); . mainDish variable holds
            // the current dish selected from menu
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            OpenMenuForm();
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
                    formatter.Serialize(stream, branchesList);
                    stream.Close();

                }

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
                branchesList = (Branches)binaryFormatter.Deserialize(stream);
                stream.Close();
            }
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
        }
    }
}
