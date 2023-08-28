﻿using System;
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
        }
        public bool hasPickles
        {
            get
            {
                return checkBoxPickles.Checked;
            }
        }
        public bool hasBacon
        {
            get
            {
                return checkBoxBacon.Checked;
            }
        }
        public bool hasTomato
        {
            get
            {
                return checkBoxTomato.Checked;
            }
        }
        public bool hasOnion
        {
            get
            {
                return checkBoxOnion.Checked;
            }
        }
        public HamburgerUserControl()
        {
            InitializeComponent();
        }
    }
}
