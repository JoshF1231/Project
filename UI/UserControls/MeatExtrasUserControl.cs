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
    public partial class MeatExtrasUserControl : UserControl
    {
        public bool rare {
            get {
                return rareButton.Checked;
            }
            set
            {
                rareButton.Checked = value;
            }
        }
        public bool medium
        {
            get
            {
                return mediumButton.Checked;
            }
            set
            {
                mediumButton.Checked = value;
            }
        }

        public bool wellDone
        {
            get
            {
                return wellDoneButton.Checked;
            }
            set
            {
                wellDoneButton.Checked = value;
            }
        }

        public MeatExtrasUserControl()
        {
            InitializeComponent();
        }

        private void MeatExtras_Load(object sender, EventArgs e)
        {

        }
    }
}
