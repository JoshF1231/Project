using Menu;
using System.Collections.Specialized;

namespace Project
{

    public partial class Form1 : Form
    {
        Branches currentBranches = new Branches();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentBranches.AddNewBranch(comboBox1.Text);
            textBox1.Text = currentBranches[0].BranchName;
        }
        
    }
}