namespace Menu
{
    [Serializable]
    public class Branch
    {
        public List<Food>? Menu;
        public string BranchName;
        public Branch() {
            Menu = new List<Food>();
            BranchName = "None";
        }
        public Branch(string branchName)
        {
            Menu = new List<Food>();
            BranchName = branchName;
        }
        override public string ToString()
        {
            if (Menu != null)
            {
                return BranchName;
            }
            else return "None";
        }
    }
}