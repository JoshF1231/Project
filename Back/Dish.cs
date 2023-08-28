namespace Menu
{
    [Serializable]

    abstract public class Dish
    {
        private double price;
        private double weight;
        public bool enabled;
        public bool isVegan { get; set; }
        public string picture = "";
        public string name {get;set;}
        public string description = "";
        public bool showItem { get; set; }
        public double Price {get=>price;set=>price=value;}
        public double Weight { get => weight; set => weight = value; }
        public abstract string GetPicture();
        public override string ToString()
        {
            return name;
        }
        protected Dish(string Name="", double Weight=0, bool isVegan=false, double Price=0)
        {
            name = Name;
            weight = Weight;
            this.isVegan = isVegan;
            this.Price = Price;
        }

    }
}