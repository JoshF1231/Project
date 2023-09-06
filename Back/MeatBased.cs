

namespace Menu
{
    [Serializable]
    public abstract class MeatBased : Dish
    {


        public bool AddVeganCheese { get; set; }
        public bool AddVeganButter { get; set; }

        private string meatType="None";
        public string MeatType { get => meatType; set => meatType = value; }
        protected MeatBased(string Name="", double Content=0, double Price=0, bool addCheese=false, bool addButter=false) : base(Name, Content, Price)
        {
            AddVeganButter = addButter;
            AddVeganCheese = addCheese;
        }
    }
}