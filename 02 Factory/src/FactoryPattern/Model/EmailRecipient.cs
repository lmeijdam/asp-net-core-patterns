namespace FactoryPattern.Model
{
    public class EmailRecipient : Recipient
    {
        public EmailRecipient(string address)
        {
             base.address = address;
        }
    }
}