using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Menu
{
    [Serializable]
    public class Branches
    {
        public List<Branch> listOfBranches;
        public Branches() {
            listOfBranches = new List<Branch>();
        }
        public void addNewBranch(string branchName)
        {
            listOfBranches.Add(new Branch(branchName));
        }
        public void removeBranch(string branchName)
        {
            Branch temp = findBranchByName(branchName);
            if (temp != null)
            {
                listOfBranches.Remove(temp);
            }
        }
        Branch? findBranchByName(string branchName)
        {
            int listSize = listOfBranches.Count;
            for (int i=0;i<listSize ; i++)
            {
                if (listOfBranches[i].BranchName == branchName)
                    return listOfBranches[i];
            }
            return null;
        }
        int amountOfBranches()
        {
            return listOfBranches.Count;
        }
    }
}