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
    public partial class Dairy : UserControl
    {
        public Dairy()
        {
            InitializeComponent();
            DairyTypeBox.DataSource = Enum.GetValues(typeof(eDairy));
        }

        private void DairyTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
