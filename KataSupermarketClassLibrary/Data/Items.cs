using KataSupermarketClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataSupermarketClassLibrary.Data {
    public static class Items 
    {
        public static List<Item> ProdItems() 
        {
            var items = new List<Item>
            {
                new Item { Id = 1, Sku = "A", UnitPrice = 10 },
                new Item { Id = 2, Sku = "B", UnitPrice = 15 },
                new Item { Id = 3, Sku = "C", UnitPrice = 40 },
                new Item { Id = 4, Sku = "D", UnitPrice = 55 }
            };

            return items;
        }
    }
}
