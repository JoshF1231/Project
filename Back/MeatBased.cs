

namespace Menu
{
    [Serializable]
    public abstract class MeatBased : Dish
    {
        public bool AddCheese { get; set; }
        public bool AddButter { get; set; }

        public bool AddVeganCheese { get; set; }
        public bool AddVeganButter { get; set; }

        private string meatType="None";
        public string MeatType { get => meatType; set => meatType = value; }
        protected MeatBased(string Name="", double Content=0, double Price=0, bool addCheese=false, bool addButter=false, bool isVegan=false) : base(Name, Content, isVegan, Price)
        {
            if(!isVegan)
            {
                AddCheese = addCheese;
                AddButter = addButter;
            }
            else
            {
                AddVeganButter = addButter;
                AddVeganCheese = addCheese;
            }
        }
    }
}