using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Menu_Form : Form
    {
        public event EventHandler<DishEventArgs>? DishIndexChanged;
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
                if (dishNameTextbox.Text.Length > 0)
                {
                    dishNameTextbox.Clear();
                }
            }
            else warning.Visible = true;
            resetListBox();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (Branch != null)
            {
                if (Branch.Menu!=null && listBoxDishes.Items.Count > 0)
                {
                    Branch.Menu.Remove(Branch[listBoxDishes.SelectedIndex]);
                }
            }
            else warning.Visible = true;
            resetListBox();
        }

        private void dishNameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton_Click(sender, e);
            }
        }

        private void listBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DishIndexChanged?.Invoke(this, new DishEventArgs(listBoxDishes.SelectedIndex));
        }
    }
}
