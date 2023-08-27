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
            MeatBasedTypeBox.DataSource = Enum.GetValues(typeof(eMeatBased));
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
    }
}
