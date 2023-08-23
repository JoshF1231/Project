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
            return BranchName;
        }
        public Dish this[int index]
        {
            get
            {
                if (index < Menu.Count) return Menu[index];
                else return null;

            }
        }
    }
}