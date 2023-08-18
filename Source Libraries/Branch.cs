namespace Menu
{
    [Serializable]
    public class Branch
    {
        public List<Dish>? Menu;
        public string BranchName;
        public Branch() {
            Menu = new List<Dish>();
            BranchName = "None";
        }
        public Branch(string branchName)
        {
            Menu = new List<Dish>();
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