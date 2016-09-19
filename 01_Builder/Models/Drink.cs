using Builder.Interfaces;

namespace Builder.Models
{
    public abstract class Drink : IItem
    {
        public abstract string Name { get; }

        public abstract float Price { get; }

        public IPacking Packing
        {
            get
            {
                return new Bottle();
            }
        }
    }
}
