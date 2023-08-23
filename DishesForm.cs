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
        public Dish? SelectedDish;
        public DishesForm()
        {
            InitializeComponent();
        }

        public DishesForm(Dish selectedDish)
        {
            InitializeComponent();
            if (selectedDish != null) { 
                SelectedDish= selectedDish;
            tempTextBox.Text = SelectedDish.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
