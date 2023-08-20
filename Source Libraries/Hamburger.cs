namespace Menu
{
    [Serializable]
    public class Hamburger : MeatBased
    {
        public override string GetPicture()
        {
            return this.picture;
        }
        public Hamburger(string Name)
        {
            this.name= Name;
        }
    }
}