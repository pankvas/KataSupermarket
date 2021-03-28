using KataSupermarketClassLibrary.Models;
using KataSupermarketClassLibrary.Data;
using System;
using System.Collections.Generic;

namespace KataSupermarket.ConsoleApp {
    class Program {
        static void Main(string[] args) {

            List<Item> _items = Items.ProdItems();

            Console.WriteLine("Shopping List\n");

            Console.WriteLine(" |----------------------------------------------------------------------|\n");
            Console.WriteLine(" | Item SKU  | Unit Price     | Promotions                              |\n");
            Console.WriteLine(" |----------------------------------------------------------------------|\n");
            
            foreach (var i in _items) {
                Console.WriteLine(String.Format(" | {0}         | {1}             | {2}                                        |",                                                   
                    i.Sku, i.UnitPrice, i.Promotion));
            }
            Console.WriteLine(" |----------------------------------------------------------------------|\n");
            Console.WriteLine("\n");
        }
    }
}
