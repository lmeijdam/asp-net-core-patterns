using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder.Models
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();
        
        public void AddItem(IItem itemToAdd)
        {
            items.Add(itemToAdd);
        }

        public float GetCosts()
        {
            return items.Sum(i => i.Price);
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine("Item: {0}, Packing: {1}, Price {2}", item.Name, item.Packing.Pack, item.Price.ToString("C"));
            }
        }
    }
}