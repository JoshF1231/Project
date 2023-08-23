namespace Menu
{
    [Serializable]

    abstract public class Dish
    {
        private double price;
        public string picture = "";
        public string name = "";
        public string description = "";
        public double Price {get=>price;set=>price=value;}
        public abstract string GetPicture();
        public override string ToString()
        {
            return name;
        }
    }
}