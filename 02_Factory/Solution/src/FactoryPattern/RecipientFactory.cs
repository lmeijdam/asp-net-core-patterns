using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;
using FactoryPattern.Model;

namespace FactoryPattern
{
    public class RecipientFactory : IRecipientFactory
    {
        public Recipient CreateRecipient(RecipientType type, string address)
        {
            switch (type)
            {
                case RecipientType.EMAIL:
                    return new EmailRecipient(address);
                case RecipientType.CC:
                    return new CCRecipient(address);
                case RecipientType.BCC:
                    return new BCCRecipient(address);
                default:
                    return new EmailRecipient(address);
            }
        }
    }
}
