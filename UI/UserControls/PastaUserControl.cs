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

        }
        public bool hasOlives
        {
            get
            {
                return checkBoxOlives.Checked;
            }

        }
        public bool hasCheese
        {
            get
            {
                return checkBoxCheese.Checked;
            }

        }
        public bool hasMushrooms
        {
            get
            {
                return checkBoxMushrooms.Checked;
            }

        }
        public bool hasVegtables
        {
            get
            {
                return checkBoxVegetables.Checked;
            }

        }
        public PastaUserControl()
        {
            InitializeComponent();
        }
    }
}
