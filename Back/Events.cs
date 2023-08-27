using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class BranchEventArgs : EventArgs
    {
        public int BranchIndex { get; }

        public BranchEventArgs(int index)
        {
            BranchIndex = index;
        }
    }
    public class DishEventArgs : EventArgs
    {
        public int DishIndex { get; }

        public DishEventArgs(int index)
        {
            DishIndex = index;
        }
    }
}
