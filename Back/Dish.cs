namespace Menu
{
    [Serializable]

    abstract public class Dish
    {
        private double price;
        private double content;
        public bool isVegan { get; set; }
        public string picture = "";
        public string name = "";
        public string description = "";
        public double Price {get=>price;set=>price=value;}
        public double Content { get => content; set => content = value; }
        public abstract string GetPicture();
        public override string ToString()
        {
            return name;
        }
        protected Dish(string Name, double Content, bool isVegan, double Price)
        {
            name = Name;
            content = Content;
            this.isVegan = isVegan;
            this.Price = Price;
        }

    }
}