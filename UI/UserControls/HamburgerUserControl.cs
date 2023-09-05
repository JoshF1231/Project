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
    public partial class HamburgerUserControl : UserControl
    {
        public bool hasLettuce
        {
            get
            {
                return checkBoxLettuce.Checked;
            }
            set
            {
                checkBoxLettuce.Checked = value;
            }
        }
        public bool hasPickles
        {
            get
            {
                return checkBoxPickles.Checked;
            }
            set
            {
                checkBoxPickles.Checked = value;
            }
        }
        public bool hasBacon
        {
            get
            {
                return checkBoxBacon.Checked;
            }
            set
            {
                checkBoxBacon.Checked = value;
            }
        }
        public bool hasTomato
        {
            get
            {
                return checkBoxTomato.Checked;
            }
            set
            {
                checkBoxTomato.Checked = value;
            }
        }
        public bool hasOnion
        {
            get
            {
                return checkBoxOnion.Checked;
            }
            set
            {
                checkBoxOnion.Checked = value;
            }
        }
        public HamburgerUserControl()
        {
            InitializeComponent();
        }
    }
}
