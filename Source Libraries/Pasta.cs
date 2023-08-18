namespace Menu
{
    [Serializable]

    public class Pasta : MeatBased
    {
        public override string GetPicture()
        {
            return this.picture;
        }
    }
}