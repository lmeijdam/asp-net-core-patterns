using System;

namespace Builder.Models
{
    public class Coffee : Drink
    {
        public override string Name
        {
            get
            {
                return "Coffee";
            }
        }

        public override float Price
        {
            get
            {
                return 1f;
            }
        }
    }
}
