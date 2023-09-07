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
    public partial class DairyExtrasUserControl : UserControl
    {
        public bool extraCheese
        {
            get
            {
                return CheeseCheckBox.Checked;
            }
            set
            {
                CheeseCheckBox.Checked = value;
            }

        }

        public bool extraButter
        {
            get
            {
                return ButterCheckBox.Checked;
            }
            set
            {
                ButterCheckBox.Checked = value;
            }

        }
        public DairyExtrasUserControl()
        {
            InitializeComponent();
        }
    }
}
