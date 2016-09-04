namespace Builder.Models
{
    public class Hamburger : Burger
    {
        public override string Name
        {
            get
            {
                return "Hamburger";
            }
        }

        public override float Price
        {
            get
            {
                return 2.80f;
            }
        }
    }
}
