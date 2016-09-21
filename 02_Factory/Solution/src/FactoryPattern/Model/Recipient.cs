using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern.Model
{
    public abstract class Recipient
    {
        protected string address = "undefined";
        public string Address => address;
    }
}
