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
}
