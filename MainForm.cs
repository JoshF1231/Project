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
        public MainForm()
        {
            InitializeComponent();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Branches_Click(object sender, EventArgs e)
        {
            loadform(new BranchesForm());
        }

        private void dishesButton_Click(object sender, EventArgs e)
        {
            loadform(new DishesForm());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            loadform(new Menu_Form());

        }
    }
}