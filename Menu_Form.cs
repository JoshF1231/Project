using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Menu_Form : Form
    {
        public Branch? Branch { get; set; }
        public Menu_Form()
        {
            InitializeComponent();
            Branch = null;
        }
        public Menu_Form(Branch branch)
        {
            InitializeComponent();
            Branch = branch;
            test.Text = branch.ToString();
        }

        private void test_Click(object sender, EventArgs e)
        {

        }
    }
}
