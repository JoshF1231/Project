﻿namespace Menu
{
    [Serializable]
    public class Pizza : Dairy
    {
        public bool AddTomato { get; set; }
        public bool AddOnion { get; set; }
        public bool AddTuna { get; set; }
        public bool AddMushrooms { get; set; }
        public bool AddBacon { get; set; }
        public Pizza(string Name, double Content, double Price, bool VeganMilk, bool addTomato, bool addOnion, bool addTuna, bool addMushrooms, bool addBacon) : base(Name, Content, Price)
        {
            AddTomato = addTomato;
            AddOnion = addOnion;
            AddTuna = addTuna;
            AddMushrooms = addMushrooms;
            AddBacon = addBacon;
        }

        public Pizza()
        {
        }
    }
}