namespace FactoryPattern.Model
{
    public class BCCRecipient : Recipient
    {
        public BCCRecipient(string address)
        {
            base.address = address;
        }
    }
}