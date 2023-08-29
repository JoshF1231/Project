using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Menu_Form : Form
    {
        public event EventHandler<DishEventArgs>? DishIndexChanged;
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
            if (Branch == null)
            {
                //   tempLabel.Text = "No branch selected";
            }
            else
            {
                //   tempLabel.Text = "Selected branch is:";
            }
            //   test.Text = branch.ToString();
            updateDataGridMenu();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (Branch != null)
            {
                OpenMenuItemForm();
            }
            else warning.Visible = true;
            //resetListBox();  --dont forget to replace
        }

        private void OpenMenuItemForm()
        {
            MenuItemForm f = new MenuItemForm();
            if (Branch != null && f.ShowDialog() == DialogResult.OK && f.tempDish != null)
            {
                Branch.Menu.Add(f.tempDish);
                updateDataGridMenu();
            }
        }
        private void OpenMenuItemForm(Dish selectedDish)
        {
            if (selectedDish != null)
            {
                MenuItemForm f = new MenuItemForm(selectedDish);
                f.ShowDialog();
            }
        }

        private void updateDataGridMenu()
        {
            BindingList<Dish> updatedMenu = new BindingList<Dish>(Branch.Menu.ToList());
            branchBindingSource.DataSource = updatedMenu;
            warning.Visible = false;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (Branch != null && menuDataGrid.SelectedCells.Count>0 && Branch.Menu!= null)
            {
                int rowIndex = menuDataGrid.SelectedCells[0].RowIndex;
                Dish? selectedDish = menuDataGrid.Rows[rowIndex].DataBoundItem as Dish;
                if (selectedDish!= null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to remove the dish: " + selectedDish.name+"?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
                    if (result==DialogResult.Yes)
                    {
                        Branch.Menu.Remove(selectedDish);
                        updateDataGridMenu();

                    }
                }
            }
            else if (Branch==null) warning.Visible = true;
            else if (Branch.Menu ==null || Branch.Menu.Count==0) {
                warning.Text = "Empty Menu!";
                warning.Visible = true;
            }
        }

        private void dishNameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton_Click(sender, e);
            }
        }

        private void listBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    DishIndexChanged?.Invoke(this, new DishEventArgs(listBoxDishes.SelectedIndex));
        }

        private void menuDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dish? dish = menuDataGrid.Rows[e.RowIndex].DataBoundItem as Dish;
            if (dish != null)
            {
                OpenMenuItemForm(dish);
            }
        }
    }
}
