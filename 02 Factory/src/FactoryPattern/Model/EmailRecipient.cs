namespace FactoryPattern.Model
{
    public class EmailRecipient : Recipient
    {
        public EmailRecipient(string address)
        {
            Address = address;
        }

        public override string Address { get; }
    }
}