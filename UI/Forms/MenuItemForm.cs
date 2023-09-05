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

        private UserControl currentExtrasControl;


        public Dish? currentDish { get; private set; }
        public Dish? oldDish { get; private set; }
        public MenuItemForm(Dish? selectedDish)
        {
            InitializeComponent();
            if (selectedDish != null)
            {
                dishPictureBox.Image = selectedDish.selectedImage;
                oldDish = selectedDish;
                currentDish = selectedDish;
                nameTextBox.Text = selectedDish.name;
                typeComboBox.Text = selectedDish.GetType().ToString().Substring(5);
                priceTextBox.Text = selectedDish.Price.ToString();
                weightTextBox.Text = selectedDish.Weight.ToString();
                descriptionTextBox.Text = selectedDish.description;
                isVeganCheckBox.Checked = selectedDish.isVegan;
                enableDishCheckBox.Checked = selectedDish.enabled;
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
                if (selectedDish is Pizza pizzaDish)
                {
                    PizzaUserControl? pizzaUserControl = (PizzaUserControl)currentIngredientControl;
                    if (pizzaUserControl != null)
                    {
                        pizzaUserControl.hasBacon = pizzaDish.AddBacon;
                        pizzaUserControl.hasMushrooms = pizzaDish.AddMushrooms;
                        pizzaUserControl.hasOnions = pizzaDish.AddOnion;
                        pizzaUserControl.hasTomato = pizzaDish.AddTomato;
                        pizzaUserControl.hasTuna = pizzaDish.AddTuna;
                    }
                }
            }
        }

        public MenuItemForm()
        {
            InitializeComponent();
            enableDishCheckBox.Checked = true;
            currentDish = null;
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
            if (typeComboBox.Text == "")
            {
                typeWarningLabel.Visible = true;
                return;
            }
            if (nameTextBox.Text == "")
            {
                nameWarningLabel.Visible = true;
                return;
            }
            if (currentIngredientControl == null) return;
            {
                switch (typeComboBox.SelectedIndex)
                {
                    case 0:
                        currentDish = new Hamburger();
                        if (currentIngredientControl is HamburgerUserControl hamburgerControl && currentDish is Hamburger hamburgerDish)
                        {
                            hamburgerDish.AddLettuce = hamburgerControl.hasLettuce;
                            hamburgerDish.AddBacon = hamburgerControl.hasBacon;
                            hamburgerDish.AddOnion = hamburgerControl.hasOnion;
                            hamburgerDish.AddPickles = hamburgerControl.hasPickles;
                            hamburgerDish.AddTomato = hamburgerControl.hasTomato;
                        }
                        break;
                    case 1:
                        currentDish = new Pizza();
                        if (currentIngredientControl is PizzaUserControl pizzaControl && currentDish is Pizza pizzaDish) // should be pizza
                                                                                                                         // TODO
                        {
                            pizzaDish.AddBacon = pizzaControl.hasBacon;
                            pizzaDish.AddMushrooms = pizzaControl.hasMushrooms;
                            pizzaDish.AddOnion = pizzaControl.hasOnions;
                            pizzaDish.AddTomato = pizzaControl.hasTomato;
                            pizzaDish.AddTuna = pizzaControl.hasTuna;
                        }
                        break;
                    case 2:
                        currentDish = new Pasta();
                        if (currentIngredientControl is PastaUserControl pastaControl && currentDish is Pasta pastaDish)
                        {
                            pastaDish.addMushrooms = pastaControl.hasMushrooms;
                            pastaDish.addOlives = pastaControl.hasOlives;
                            pastaDish.addVegetables = pastaControl.hasVegtables;
                            pastaDish.addtomatoSauce = pastaControl.hasTomatoSauce;
                        }
                        break;
                    default:
                        currentDish = null;
                        break;
                }
                if (currentDish != null)
                {
                    currentDish.name = nameTextBox.Text;
                    currentDish.description = descriptionTextBox.Text;
                    double price;
                    if (double.TryParse(priceTextBox.Text, out price))
                    {
                        currentDish.Price = price;
                    }
                    else
                    {
                        priceWarningLabel.Visible = true;
                        return;
                    }
                    double weight;
                    if (double.TryParse(weightTextBox.Text, out weight))
                    {
                        currentDish.Weight = weight;
                    }
                    else
                    {
                        weightWarningLabel.Visible = true;
                        return;
                    }
                    currentDish.isVegan = isVeganCheckBox.Checked;
                    currentDish.enabled = enableDishCheckBox.Checked;
                    currentDish.selectedImage = dishPictureBox.Image;
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
                        if (currentDish == null)
                        {
                            currentDish = new Hamburger();
                        }
                        BonusPanel.Controls.Add(currentIngredientControl, 0, 0);
                        break;
                    }
                case 1:
                    {
                        currentIngredientControl = new PizzaUserControl();
                        if (currentDish == null)
                        {
                            currentDish = new Pizza();
                        }
                        BonusPanel.Controls.Add(currentIngredientControl, 0, 0);
                        break;
                    }
                case 2:
                    {
                        currentIngredientControl = new PastaUserControl();
                        if (currentDish == null)
                        {
                            currentDish = new Pasta();
                        }
                        BonusPanel.Controls.Add(currentIngredientControl, 0, 0);
                        break;
                    }
                default:
                    {
                        currentIngredientControl = new PastaUserControl();
                        typeComboBox.SelectedIndex = 0;
                        break;
                    }
            }
            if (currentDish!= null)
            {
                if (currentDish is Dairy) {
                    currentExtrasControl = new ExtrasUserControl("Dairy");
                }
                if (currentDish is MeatBased)
                {
                    currentExtrasControl = new ExtrasUserControl();
                }
                BonusPanel.Controls.Add(currentExtrasControl, 1, 0);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void enableDishCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imageUploadButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a dish type first.");
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    if (currentDish == null)
                    {
                        // Depending on the selected type, create an instance of the appropriate Dish subclass
                        switch (typeComboBox.SelectedIndex)
                        {
                            case 0:
                                currentDish = new Hamburger();
                                break;
                            case 1:
                                currentDish = new Pizza();
                                break;
                            case 2:
                                currentDish = new Pasta();
                                break;
                            default:
                                currentDish = null;
                                break;
                        }
                    }

                    if (currentDish != null)
                    {
                        currentDish.selectedImage = Image.FromFile(imagePath);
                        updatePictureBox();
                    }
                }
            }
        }
        private void updatePictureBox()
        {
            if (currentDish != null)
            {
                dishPictureBox.Image = currentDish.selectedImage;
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
