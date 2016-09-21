using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.Model;

namespace FactoryPattern.Interfaces
{
    interface IRecipientFactory
    {
        Recipient CreateRecipient(RecipientType type, string address);
    }
}
