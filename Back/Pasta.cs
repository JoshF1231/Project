namespace Menu
{
    [Serializable]

    public class Pasta : Dairy
    {
        public bool addCheese {  get; set; }
        public bool addOlives { get; set; }
        public bool addtomatoSauce { get; set; }
        public bool addMushrooms { get; set; }
        public bool addVegetables { get; set; }
    

        public Pasta()
        {

        }

        public Pasta(string Name, double Content, double Price, bool extraCheese, bool addOlives, bool tomatoSauce, bool addMushrooms, bool addVegetables) : base(Name, Content, Price)
        {
            this.addCheese = extraCheese;
            this.addOlives = addOlives;
            this.addtomatoSauce = tomatoSauce;
            this.addMushrooms = addMushrooms;
            this.addVegetables = addVegetables;
        }
    }
}