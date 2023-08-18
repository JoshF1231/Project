namespace Menu
{
    abstract public class Food
    {
        private double price;
        public string picture = "";
        public double Price {get=>price;set=>price=value;}
        public abstract string GetPicture();
    }
}