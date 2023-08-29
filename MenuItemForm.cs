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
        private UserControl currentIngredientControl; // Class-level variable to store the loaded UserControl
        public Dish? tempDish { get; private set; }

        public MenuItemForm(Dish? selectedDish)
        {
            InitializeComponent();
            if (selectedDish!= null) { 
                tempDish = selectedDish;
                applyButton.Enabled = false;
                nameTextBox.Text = selectedDish.name;
                nameTextBox.Enabled = false;
                typeComboBox.Text = selectedDish.GetType().ToString().Substring(5);
                typeComboBox.Enabled = false;
                priceTextBox.Text = selectedDish.Price.ToString();
                priceTextBox.Enabled = false;
                weightTextBox.Text = selectedDish.Weight.ToString();
                weightTextBox.Enabled = false;
                descriptionTextBox.Text = selectedDish.description;
                descriptionTextBox.Enabled = false;
                isVeganCheckBox.Checked = selectedDish.isVegan;
                isVeganCheckBox.Enabled = false;
                enableDishCheckBox.Checked = selectedDish.enabled;
                enableDishCheckBox.Enabled= false;
                if (selectedDish is Hamburger hamburgerDish)
                {
                    HamburgerUserControl? hamburgerUserControl = (HamburgerUserControl)currentIngredientControl;
                    if (hamburgerUserControl != null)
                    {
                        hamburgerUserControl.hasBacon = hamburgerDish.AddBacon;
                        hamburgerUserControl.hasLettuce = hamburgerDish.AddLettuce;
                        hamburgerUserControl.hasOnion = hamburgerDish.AddOnion;
                        hamburgerUserControl.hasTomato = hamburgerDish.AddTomato;
                        hamburgerUserControl.hasPickles = hamburgerDish.AddPickles;
                    }
                }
                if (selectedDish is Pasta pastaDish)
                {
                    PastaUserControl? pastaUserControl = (PastaUserControl)currentIngredientControl;
                    if (pastaUserControl != null)
                    {
                        pastaUserControl.hasTomatoSauce = pastaDish.addtomatoSauce;
                        pastaUserControl.hasMushrooms = pastaDish.addMushrooms;
                        pastaUserControl.hasOlives = pastaDish.addOlives;
                        pastaUserControl.hasVegtables = pastaDish.addVegetables;
                        pastaUserControl.hasCheese = pastaDish.extraCheese;
                    }
                }
            }
        }

        public MenuItemForm()
        {
            InitializeComponent();
            tempDish = null;
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
            if (currentIngredientControl == null) return;
            {
                switch (typeComboBox.SelectedIndex)
                {
                    case 0:
                        tempDish = new Hamburger();
                        if (currentIngredientControl is HamburgerUserControl hamburgerControl && tempDish is Hamburger hamburgerDish)
                        {
                            hamburgerDish.AddLettuce = hamburgerControl.hasLettuce;
                            hamburgerDish.AddBacon = hamburgerControl.hasBacon;
                            hamburgerDish.AddOnion = hamburgerControl.hasOnion;
                            hamburgerDish.AddPickles = hamburgerControl.hasPickles;
                            hamburgerDish.AddTomato = hamburgerControl.hasTomato;
                        }
                        break;
                    case 1:
                        tempDish = new Pizza();
                        if (currentIngredientControl is HamburgerUserControl hamburgerControltemp) // should be pizza
                            // TODO
                        {

                        }
                            break;
                    case 2:
                        tempDish = new Pasta();
                        if (currentIngredientControl is PastaUserControl pastaControl && tempDish is Pasta pastaDish)
                        {
                            pastaDish.addMushrooms=pastaControl.hasMushrooms;
                            pastaDish.addOlives=pastaControl.hasOlives;
                            pastaDish.addVegetables = pastaControl.hasVegtables;
                            pastaDish.addtomatoSauce = pastaControl.hasTomatoSauce;
                        }
                        break;
                    default:
                        tempDish = null;
                        break;
                }
                if (tempDish != null)
                {
                    tempDish.name = nameTextBox.Text;
                    tempDish.description = descriptionTextBox.Text;
                    double price;
                    if (double.TryParse(priceTextBox.Text, out price))
                    {
                        tempDish.Price = price;
                    }
                    else
                    {
                        priceWarningLabel.Visible = true;
                    }
                    double weight;
                    if (double.TryParse(weightTextBox.Text, out weight))
                    {
                        tempDish.Weight = weight;
                    }
                    else
                    {
                        weightWarningLabel.Visible = true;
                    }
                    tempDish.isVegan = isVeganCheckBox.Checked;
                    tempDish.enabled = enableDishCheckBox.Checked;
                }
                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BonusPanel.Controls.Clear();
            switch (typeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        currentIngredientControl = new HamburgerUserControl();
                        BonusPanel.Controls.Add(currentIngredientControl, 0, 0);
                        break;
                    }
                case 1:
                    {
                        currentIngredientControl = new HamburgerUserControl();
                        BonusPanel.Controls.Add(currentIngredientControl, 0, 0);
                        break;
                    }
                case 2:
                    {
                        currentIngredientControl = new PastaUserControl();
                        BonusPanel.Controls.Add(currentIngredientControl, 0, 0);
                        break;
                    }
                default: {
                        currentIngredientControl = new PastaUserControl();
                        typeComboBox.SelectedIndex = 0;
                        break; 
                    }
            }
        }

        //private void priceTextBox_Leave(object sender, EventArgs e)
        //{
        //    double temp;
        //    if (!double.TryParse(priceTextBox.Text,out temp))
        //    {
        //        priceWarningLabel.Visible = true;
        //    }
        //}

        //private void priceTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    priceWarningLabel.Visible = false;
        //}

        //private void weightTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    weightWarningLabel.Visible = false;
        //}
    }
}
