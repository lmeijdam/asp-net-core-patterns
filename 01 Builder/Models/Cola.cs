namespace Builder.Models
{
    public class Cola : Drink
    {
        public override string Name
        {
            get
            {
                return "Cola";
            }
        }

        public override float Price
        {
            get
            {
                return 1.50f;
            }
        }
    }
}
