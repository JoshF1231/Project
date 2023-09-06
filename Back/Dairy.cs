namespace Menu
{
    [Serializable]
    public abstract class Dairy : Dish
    {

        public bool extraCheese { get; set; }
        public bool extraButter { get; set; }

        public Dairy()
        {
        }
        protected Dairy(string Name="", double Weight=0, double Price=0) : base(Name, Weight, Price)
        {

        }




    }
}
