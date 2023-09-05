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
    public partial class PizzaUserControl : UserControl
    {
        public bool hasTomato
        {
            get
            {
                return checkBoxTomatoPizza.Checked;
            }
            set
            {
                checkBoxTomatoPizza.Checked = value;
                checkBoxTomatoPizza.Enabled = false;
            }

        }
        public bool hasOnions
        {
            get
            {
                return checkBoxOnionPizza.Checked;
            }
            set
            {
                checkBoxOnionPizza.Checked = value;
                checkBoxOnionPizza.Enabled = false;
            }
        }
        public bool hasTuna
        {
            get
            {
                return checkBoxTunaPizza.Checked;
            }
            set
            {
                checkBoxTunaPizza.Checked = value;
                checkBoxTunaPizza.Enabled = false;
            }

        }
        public bool hasMushrooms
        {
            get
            {
                return checkBoxMushroomsPizza.Checked;
            }
            set
            {
                checkBoxMushroomsPizza.Checked = value;
                checkBoxMushroomsPizza.Enabled = false;
            }

        }
        public bool hasBacon
        {
            get
            {
                return checkBoxBaconPizza.Checked;
            }
            set
            {
                checkBoxBaconPizza.Checked = value;
                checkBoxBaconPizza.Enabled = false;
            }

        }
        public PizzaUserControl()
        {
            InitializeComponent();
        }
    }
}
