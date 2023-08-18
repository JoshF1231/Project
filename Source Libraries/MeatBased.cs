

namespace Menu
{
    abstract public class MeatBased : Food
    {
        private string meatType="None";
        public string MeatType { get => meatType; set => meatType = value; }
    }
}