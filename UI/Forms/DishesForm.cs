using Menu;
using Project.Back.Enum;
using Project.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dairy = Project.UI.UserControls.Dairy;
using MeatBased = Project.UI.UserControls.MeatBased;

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
            if (SelectedBranchMenu != null && SelectedBranchMenu.Menu != null && SelectedBranchMenu.Menu.Count > 0)
            {
                dishesListBox.Items.Clear();
                for (int i = 0; i < SelectedBranchMenu.Menu.Count; i++)
                {
                    dishesListBox.Items.Add(SelectedBranchMenu[i].name);
                }
            }
        }
        private void MeatBasedPanelButton_Click(object sender, EventArgs e)
        {
            PanelUserControl.Controls.Clear();
            PanelUserControl.Controls.Add(new MeatBased());
        }

        private void DairyPanelButton_Click(object sender, EventArgs e)
        {
            PanelUserControl.Controls.Clear();
            PanelUserControl.Controls.Add(new Dairy());

        }

        private void DishesForm_Load(object sender, EventArgs e)
        {

        }

        private void PanelUserControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
