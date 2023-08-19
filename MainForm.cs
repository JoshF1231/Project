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
        Branch? temp { get; set; }
        public Branches currentBranches { get; set; }
        public MyForm activeForm { get; set; }
        public MainForm()
        {
            InitializeComponent();
            temp=null;
        }

        public void loadform(object Form)
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

        private void Branches_Click(object sender, EventArgs e)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            BranchesForm f = new BranchesForm();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.callingForm = this;
            f.Show();
            if (f.index>=0) { 
            temp = f.currentBranches[f.index];
                MessageBox.Show("index is valid");
            }
            else MessageBox.Show("index is invalid");
            activeForm = f;
        }

        private void dishesButton_Click(object sender, EventArgs e)
        {
            loadform(new DishesForm());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            int index = activeForm.receiveData();
            activeForm.Close();
            if (temp!= null) { 
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            //Menu_Form f = new Menu_Form(temp);
            //f.TopLevel = false;
            //f.Dock = DockStyle.Fill;
            //this.mainpanel.Controls.Add(f);
            //this.mainpanel.Tag = f;
            //}
            //f.Branch=...
        }
    }
}