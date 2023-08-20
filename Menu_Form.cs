using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Menu_Form : Form
    {
        public Branch? Branch { get; set; }
        public Menu_Form()
        {
            InitializeComponent();
            Branch = null;
            tempLabel.Text = "No branch selected";
            listBoxDishes.Items.Clear();
        }
        public Menu_Form(Branch branch)
        {
            InitializeComponent();
            Branch = branch;
            if (Branch == null)
            {
                tempLabel.Text = "No branch selected";
            }
            else
            {
                tempLabel.Text = "Selected branch is:";
            }
            test.Text = branch.ToString();
            resetListBox();
        }
        public void resetListBox()
        {
            listBoxDishes.Items.Clear();
            if (Branch != null && Branch.Menu != null)
            {
                for (int i = 0; i < Branch.Menu.Count; i++)
                {
                    listBoxDishes.Items.Add(Branch.Menu[i].name);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Branch != null)
            {
                if (dishNameTextbox.Text.Length > 0) { 
                Branch.Menu.Add(new Hamburger(dishNameTextbox.Text));
                }
            }
            else warning.Visible = true;
            resetListBox();
        }
    }
}
