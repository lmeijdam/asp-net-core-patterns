namespace FactoryPattern.Model
{
    public class CCRecipient : Recipient
    {
        public CCRecipient(string address)
        {
            base.address = address;
        }
        
    }
}