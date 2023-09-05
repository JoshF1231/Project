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
    public partial class MeatBasedUserControl : UserControl
    {
        public bool hasCheese
        {
            get
            {
                return CheeseCheckBox.Checked;
            }
            set
            {
                CheeseCheckBox.Checked = value;
                CheeseCheckBox.Enabled = false;
            }

        }

        public bool hasButter
        {
            get
            {
                return ButterCheckBox.Checked;
            }
            set
            {
                ButterCheckBox.Checked = value;
                ButterCheckBox.Enabled = false;
            }

        }
        public MeatBasedUserControl()
        {
            InitializeComponent();
        }
    }
}
