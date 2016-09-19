using Builder.Interfaces;

namespace Builder.Models
{
    public class Wrapper : IPacking
    {
        public string Pack
        {
            get { return "Wrapper"; }
        }
    }
}