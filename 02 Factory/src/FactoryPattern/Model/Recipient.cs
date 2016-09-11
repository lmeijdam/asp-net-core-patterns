using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern.Model
{
    public abstract class Recipient
    {
        public abstract string Address { get; }
    }
}
