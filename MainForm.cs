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
        public Branch mainBranch;
        public Branches currentBranches { get; set; }
        public MyForm activeForm { get; set; }
        public MainForm()
        {
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

            mainBranch = new Branch();
            BranchesForm f = new BranchesForm(mainBranch);

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            // Subscribe to the event in the sub-form
            f.BranchUpdated += BranchesForm_BranchUpdated;

            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void OpenMenuForm()
        {

            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            Menu_Form f = new Menu_Form(mainBranch);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void BranchesForm_BranchUpdated(object sender, BranchEventArgs e)
        {
            // Update the main form based on the changes made in the sub-form
            mainBranch = e.UpdatedBranch;
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
    }
}