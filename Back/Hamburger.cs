namespace Menu
{
    [Serializable]
    public class Hamburger : MeatBased
    {
        public bool AddTomato { get; set; }
        public bool AddOnion { get; set; }
        public bool AddLettuce { get; set; }
        public bool AddPickles { get; set; }
        public bool AddBacon { get; set; }

        public Hamburger(string Name, double Content, double Price, bool addCheese, bool addButter, bool tomato, bool onion, bool lettuce, bool pickles, bool bacon) : base(Name, Content, Price, addButter, addCheese)
        {
            AddTomato = tomato;
            AddOnion = onion;
            AddLettuce = lettuce;
            AddPickles = pickles;
            AddBacon = bacon;
        }

        public Hamburger()
        {
        }
    }
}