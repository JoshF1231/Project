namespace Menu
{
    [Serializable]
    public class Pizza : Dairy
    {
        public override string GetPicture()
        {
            return this.picture;
        }
    }
}