using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Models
{
    public class PaypalStrategy : IPaymentStrategy
    {
        private string _email;
        private string _password;

        public PaypalStrategy(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void Pay(int amount)
        {
            var authorized = LogInUser(_email, _password);
            if (authorized)
            {
                Console.WriteLine($"{amount} euro's paid by {_email} with Paypal");
            }
            else
            {
                Console.WriteLine($"{_email} is not a valid user. Please log in.");
            }
        }

        private bool LogInUser(string email, string password)
        {
            return (email != password);
        }
    }
}
