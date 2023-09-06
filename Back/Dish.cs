namespace Menu
{
    [Serializable]

    abstract public class Dish
    {
        private double price;
        private double weight;
        public bool enabled { get; set; }
        public string name {get;set;}
        public string description = "";
        public double Price {get=>price;set=>price=value;}
        public double Weight { get => weight; set => weight = value; }
        public Image selectedImage {
            get; set; }
        public override string ToString()
        {
            return name;
        }
        protected Dish(string Name="", double Weight=0, double Price=0,bool dishEnabled = true)
        {
            name = Name;
            weight = Weight;
            this.Price = Price;
            enabled = dishEnabled;
        }

    }
}