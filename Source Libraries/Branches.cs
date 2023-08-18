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
        public void AddNewBranch(string branchName)
        {
            listOfBranches.Add(new Branch(branchName));
        }
        public void RemoveBranch(string branchName)
        {
            Branch temp = FindBranchByName(branchName);
            if (temp != null)
            {
                listOfBranches.Remove(temp);
            }
        }
        Branch? FindBranchByName(string branchName)
        {
            int listSize = listOfBranches.Count;
            for (int i = 0; i < listSize; i++)
            {
                if (listOfBranches[i].BranchName == branchName)
                    return listOfBranches[i];
            }
            return null;
        }
        int AmountOfBranches()
        {
            return listOfBranches.Count;
        }
        public Branch this[int index]
        {
            get { return listOfBranches[index]; }   
        }

        
    }
}