namespace Menu
{
    [Serializable]

    public class Pasta : Dairy
    {
        public bool extraCheese {  get; set; }
        public bool addOlives { get; set; }
        public bool tomatoSauce { get; set; }
        public bool addMushrooms { get; set; }
        public bool addVegetables { get; set; }
    

        public override string GetPicture()
        {
            return this.picture;
        }
        public Pasta()
        {

        }

        public Pasta(string Name, double Content, double Price, bool isVegan, bool VeganMilk, bool extraCheese, bool addOlives, bool tomatoSauce, bool addMushrooms, bool addVegetables) : base(Name, Content, isVegan, Price)
        {
            this.extraCheese = extraCheese;
            this.addOlives = addOlives;
            this.tomatoSauce = tomatoSauce;
            this.addMushrooms = addMushrooms;
            this.addVegetables = addVegetables;
            GetPicture();
        }
    }
}