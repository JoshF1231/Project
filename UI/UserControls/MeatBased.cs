using Menu;
using Project.Back.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI.UserControls
{
    public partial class MeatBased : UserControl
    {
        public MeatBased()
        {
            InitializeComponent();
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MeatBasedTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Name = NameTextBox.Text;
            double Content = Double.Parse(ContentTextBox.Text);
            string Description = DescriptionTextBox.Text;
            bool AddCheese = CheeseCheckBox.Checked;
            bool AddButter = ButterCheckBox.Checked;
            double Price = Double.Parse(PriceTextBox.Text);
        }
    }
}
