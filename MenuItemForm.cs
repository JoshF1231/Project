using Menu;
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

namespace Project
{
    public partial class MenuItemForm : Form
    {
        public Branch? currBranch;
        public MenuItemForm(Branch branch)
        {
            InitializeComponent();
            currBranch = branch;
        }
        public MenuItemForm()
        {
            InitializeComponent();
            currBranch = null;
        }
        private void MenuItemForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (currBranch != null)
            {
                Dish temp;
                switch (typeComboBox.SelectedIndex)
                {
                    case 0:
                        temp = new Hamburger();
                        break;
                    case 1:
                        temp = new Pizza();
                        break;
                    case 2:
                        temp = new Pasta();
                        break;
                    default: temp = null; break;
                }
                if (temp != null)
                {
                    temp.name = nameTextBox.Text;
                    temp.description = descriptionTextBox.Text;
                    temp.Price = double.Parse(priceTextBox.Text);
                    temp.Weight = double.Parse(weightTextBox.Text);
                    temp.isVegan = isVeganCheckBox.Checked;
                    temp.enabled = enableDishCheckBox.Checked;
                    currBranch.AddDish(temp);
                    MessageBox.Show(currBranch[0].ToString());
                }
            }
            Close();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BonusPanel.Controls.Clear();
            UserControl ingredientControl;
            switch (typeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        ingredientControl = new HamburgerUserControl();
                        BonusPanel.Controls.Add(ingredientControl, 0, 0);
                        break;
                    }
                case 1:
                    {
                        ingredientControl = new PastaUserControl();
                        BonusPanel.Controls.Add(ingredientControl, 0, 0);
                        break;
                    }
                default: {
                        ingredientControl = new HamburgerUserControl();
                        typeComboBox.SelectedIndex = 0;
                        break; 
                    }
            }
        }
    }
}
