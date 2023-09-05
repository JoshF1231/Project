using Menu;
using Project.Back.Enum;
using Project.UI.Titles;
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
using MeatBased = Project.UI.UserControls.MeatBasedUserControl;

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
            TitlePanel.Controls.Clear();
            TitlePanel.Controls.Add(new MeatTitle());
            TypeBox.DataSource = Enum.GetValues(typeof(eMeatBased));
        }

        private void DairyPanelButton_Click(object sender, EventArgs e)
        {
            PanelUserControl.Controls.Clear();
            TitlePanel.Controls.Clear();
            TitlePanel.Controls.Add(new DairyTitle());
            TypeBox.DataSource = Enum.GetValues(typeof(eDairy));
        }

        private void DishesForm_Load(object sender, EventArgs e)
        {

        }

        private void PanelUserControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelUserControl.Controls.Clear();
            if (TypeBox.SelectedItem.ToString() == eMeatBased.Hamburger.ToString())
            {
                PanelIngredients.Controls.Clear();
                PanelIngredients.Controls.Add(new HamburgerUserControl());
                PanelUserControl.Controls.Clear();
                PanelUserControl.Controls.Add(new MeatBased());
                pictureBoxDishes.Image = imageListDishes.Images[0];
                richTextBoxFacts.Text = "A hamburger, or simply burger, is a sandwich consisting of fillings—usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll.";
            }

            if (TypeBox.SelectedItem.ToString() == eMeatBased.Other.ToString())
            {
                PanelIngredients.Controls.Clear();
                PanelUserControl.Controls.Clear();
                PanelUserControl.Controls.Add(new MeatBased());
                pictureBoxDishes.Image = null;
            }

            if (TypeBox.SelectedItem.ToString() == "None")
            {
                PanelIngredients.Controls.Clear();
                PanelUserControl.Controls.Clear();
                pictureBoxDishes.Image = null;
            }

            if (TypeBox.SelectedItem.ToString() == eDairy.Pasta.ToString())
            {
                PanelIngredients.Controls.Clear();
                PanelIngredients.Controls.Add(new PastaUserControl());
                pictureBoxDishes.Image = imageListDishes.Images[1];
                richTextBoxFacts.Text = "Pasta is a type of food typically made from an unleavened dough of wheat flour mixed with water or eggs, and formed into sheets or other shapes, then cooked by boiling or baking.";
            }
        }
    }
}
