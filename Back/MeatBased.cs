public enum DonenessLevel
{
    Rare,
    Medium,
    WellDone
}

namespace Menu
{
    [Serializable]
    public abstract class MeatBased : Dish
    {
        public DonenessLevel Doneness { get; set; }
        protected MeatBased(string Name="", double Content=0, double Price=0) : base(Name, Content, Price)
        {
        }
    }
}