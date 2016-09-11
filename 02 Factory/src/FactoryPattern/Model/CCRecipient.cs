namespace FactoryPattern.Model
{
    public class CCRecipient : Recipient
    {
        public CCRecipient(string address)
        {
            Address = address;
        }

        public override string Address { get; }
    }
}