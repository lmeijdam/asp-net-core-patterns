namespace Builder.Models
{
    public class ChickenBurger : Burger
    {
        public override string Name
        {
            get
            {
                return "ChickenBurger";
            }
        }

        public override float Price
        {
            get
            {
                return 2.50f;
            }
        }
    }
}