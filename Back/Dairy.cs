namespace Menu
{
    [Serializable]
    public abstract class Dairy : Dish
    {
        private string dairyType = "None";
        public string DairyType { get => dairyType; set => dairyType = value; }
        public string? DairySource { get; set; }
        
        public bool VeganMilk { get; set; }

        public Dairy()
        {

        }
        protected Dairy(string Name, double Content, bool isVegan, double Price) : base(Name, Content, isVegan, Price)
        {
            if(isVegan)
            {
                this.VeganMilk = true;
                DairyType = "Vegan";
            }
            else
            {
                this.VeganMilk = false;
            }
        }




    }
}
