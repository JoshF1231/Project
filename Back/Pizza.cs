namespace Menu
{
    [Serializable]
    public class Pizza : Dairy
    {
        public bool AddTomato { get; set; }
        public bool AddOnion { get; set; }
        public bool AddTuna { get; set; }
        public bool AddMushrooms { get; set; }
        public bool AddBacon { get; set; }

        public override string GetPicture()
        {
            return this.picture;
        }
        public Pizza(string Name, double Content, bool isVegan, bool VeganMilk, bool addTomato, bool addOnion, bool addTuna, bool addMushrooms, bool addBacon) : base(Name, Content, isVegan)
        {
            AddTomato = addTomato;
            AddOnion = addOnion;
            AddTuna = addTuna;
            AddMushrooms = addMushrooms;
            AddBacon = addBacon;
        }
    }
}