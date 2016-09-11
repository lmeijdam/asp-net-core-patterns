using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class WalletStrategy : IPaymentStrategy
    {
        private string _username;
        public WalletStrategy(string username)
        {
            _username = username;
        }
        public void Pay(int amount)
        {
            Console.WriteLine($"{amount} euro's paid by {_username} using In-Game Wallet.");
        }
    }
}
