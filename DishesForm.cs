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
    public partial class DishesForm : Form
    {
        public Branch? SelectedBranchMenu;
        public DishesForm()
        {
            InitializeComponent();
        }

        public DishesForm(Branch selectedBranchMenu)
        {
            InitializeComponent();
            if (selectedBranchMenu != null)
            {
                SelectedBranchMenu = selectedBranchMenu;
                resetListBox();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void resetListBox()
        {
            if (SelectedBranchMenu != null && SelectedBranchMenu.Menu != null&& SelectedBranchMenu.Menu.Count>0)
            {
                dishesListBox.Items.Clear();
                    for (int i = 0; i < SelectedBranchMenu.Menu.Count; i++)
                    {
                    dishesListBox.Items.Add(SelectedBranchMenu[i].name);
                    }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
