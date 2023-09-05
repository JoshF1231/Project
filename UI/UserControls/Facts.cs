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
    public partial class Facts : UserControl
    {
        public void hasHamburger()
        {
                richTextBoxFacts.Text = "A hamburger, or simply burger, is a sandwich consisting of fillings—usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll.";  
        }

        public void hasPizza()
        {
                richTextBoxFacts.Text = "Pizza is a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredients, which is then baked at a high temperature, traditionally in a wood-fired oven.";
        }

        public void hasPasta()
        {
                richTextBoxFacts.Text = "Pasta is a type of food typically made from an unleavened dough of wheat flour mixed with water or eggs, and formed into sheets or other shapes, then cooked by boiling or baking.";
        }
        public Facts()
        {
            InitializeComponent();
        }
    }
}
