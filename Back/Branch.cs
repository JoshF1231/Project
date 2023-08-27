using Project.Back;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Menu
{
    [Serializable]
    public class Branch
    {
        public BindingList<Dish>? Menu { get; set; }
        public string BranchName;
        public Branch() {
            Menu = new BindingList<Dish>();
            BranchName = "None";
        }
        public Branch(string branchName)
        {
            Menu = new BindingList<Dish>();
            BranchName = branchName;
        }

        public void RemoveDish(Dish dish)
        {
            Menu.Remove(dish);
        }

        public void AddDish(Dish dish)
        {
            Menu.Add(dish);
        }

        override public string ToString()
        {
            return BranchName;
        }
        public Dish this[int index]
        {
            get
            {
                if (index < Menu.Count && index>=0) return Menu[index];
                else return null;

            }
        }
    }
}