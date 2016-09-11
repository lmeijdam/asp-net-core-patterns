using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;
using FactoryPattern.Model;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IRecipientFactory recipientFactory = new RecipientFactory();
            Recipient emailRecipient = recipientFactory.CreateRecipient(RecipientType.EMAIL, "johan.boersma@gmail.com");
            Recipient ccRecipient = recipientFactory.CreateRecipient(RecipientType.CC, "stefandevries@hotmail.com");
            Recipient bccRecipient = recipientFactory.CreateRecipient(RecipientType.BCC, "japie95@live.nl");

            Console.WriteLine($"Created a recipient of type {emailRecipient.GetType()} with address: {emailRecipient.Address}");
            Console.WriteLine($"Created a recipient of type {ccRecipient.GetType()} with address: {ccRecipient.Address}");
            Console.WriteLine($"Created a recipient of type {bccRecipient.GetType()} with address: {bccRecipient.Address}");

            Console.ReadKey();
        }
    }
}
