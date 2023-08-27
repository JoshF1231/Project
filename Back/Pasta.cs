namespace Menu
{
    [Serializable]

    public class Pasta : Dairy
    {
        public bool extraCheese {  get; set; }
        public bool addOlives { get; set; }

        public override string GetPicture()
        {
            return this.picture;
        }

        public Pasta(string Name, double Content, bool isVegan, bool VeganMilk, bool extraCheese, bool addOlives) : base(Name, Content, isVegan)
        {
            this.extraCheese = extraCheese;
            this.addOlives = addOlives;
            GetPicture();
        }
    }
}