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
    public partial class PastaUserControl : UserControl
    {
        public bool hasTomatoSauce { get
            {
                return checkBoxTomatoSauce.Checked;
            }
            set
            {
                checkBoxTomatoSauce.Checked = value;
                checkBoxTomatoSauce.Enabled = false;
            }

        }
        public bool hasOlives
        {
            get
            {
                return checkBoxOlives.Checked;
            }
            set
            {
                checkBoxOlives.Checked = value;
                checkBoxOlives.Enabled = false;
            }
        }
        public bool hasCheese
        {
            get
            {
                return checkBoxCheese.Checked;
            }
            set
            {
                checkBoxCheese.Checked = value;
                checkBoxCheese.Enabled = false;
            }

        }
        public bool hasMushrooms
        {
            get
            {
                return checkBoxMushrooms.Checked;
            }
            set
            {
                checkBoxMushrooms.Checked = value;
                checkBoxMushrooms.Enabled = false;
            }

        }
        public bool hasVegtables
        {
            get
            {
                return checkBoxVegetables.Checked;
            }
            set
            {
                checkBoxVegetables.Checked = value;
                checkBoxVegetables.Enabled = false;
            }

        }
        public PastaUserControl()
        {
            InitializeComponent();
        }
    }
}
