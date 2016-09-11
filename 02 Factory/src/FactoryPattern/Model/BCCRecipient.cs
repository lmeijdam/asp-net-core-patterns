namespace FactoryPattern.Model
{
    public class BCCRecipient : Recipient
    {
        public BCCRecipient(string address)
        {
            Address = address;
        }

        public override string Address { get; }
    }
}