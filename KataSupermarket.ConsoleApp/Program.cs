using KataSupermarketClassLibrary.Models;
using KataSupermarketClassLibrary.Data;

using System;
using System.Collections.Generic;
using System.Linq;

namespace KataSupermarket.ConsoleApp {
    class Program {
        static void Main(string[] args) {

            List<Item> _items = Items.ProdItems();           

            Console.WriteLine("Shopping List (press 'e' to exit)\n" );
            Console.WriteLine(" |----------------------------------------------------------------------|\n");
            Console.WriteLine(" | Item SKU  | Unit Price     | Promotions                              |\n");
            Console.WriteLine(" |----------------------------------------------------------------------|\n");

            foreach (var i in _items) {
                Console.WriteLine(String.Format(" | {0}         | {1}             | {2}                                        |",
                    i.Sku, i.UnitPrice, i.Promotion));
            }
            Console.WriteLine(" |----------------------------------------------------------------------|\n");
            Console.WriteLine("\n");

            //SuperMarket sm = new SuperMarket(); 

            Console.WriteLine("Add item to basket");
            while (true) {
                var key = Console.ReadKey(true);
                if (key.KeyChar == 'e')
                    break;
                else if (new char[] { 'A', 'B', 'C', 'D' }.Contains(key.KeyChar)) {
                    AddToBasket(key.KeyChar);
                }

                else
                    Console.WriteLine(String.Format("{0} is not available or out of stock", key.KeyChar));
            }
        }

        private static void AddToBasket(char keyChar) {

            List<Item> _items = Items.ProdItems();
            List<Item> myShoppingList = new List<Item>();
            decimal total = 0m;

            switch (keyChar) {
                case 'A':
                    var up = from item in _items
                             where item.Sku == "A"
                             select item;

                    myShoppingList.Add(new Item {
                        Id = up.ToList()[0].Id
                        , Sku = up.ToList()[0].Sku
                        , UnitPrice = up.ToList()[0].UnitPrice
                        , Promotion = up.ToList()[0].Promotion
                    });

                    total += Checkout( myShoppingList);
                    Console.WriteLine(total);
                    break;
                case 'B':

                    var up1 = from item in _items
                              where item.Sku == "B"
                              select item;                    

                    myShoppingList.Add(new Item {
                        Id = up1.ToList()[0].Id
                      , Sku = up1.ToList()[0].Sku
                      , UnitPrice = up1.ToList()[0].UnitPrice
                      , Promotion = up1.ToList()[0].Promotion
                    });

                    total += Checkout(myShoppingList);
                    Console.WriteLine(total);
                    break;
                case 'C':

                    var up2 = from item in _items
                              where item.Sku == "C"
                              select item;

                    myShoppingList.Add(new Item {
                        Id = up2.ToList()[0].Id
                      , Sku = up2.ToList()[0].Sku
                      , UnitPrice = up2.ToList()[0].UnitPrice
                      , Promotion = up2.ToList()[0].Promotion
                    });
                    total += Checkout(myShoppingList);
                    Console.WriteLine(total);
                    break;
                case 'D':

                    var up3 = from item in _items
                              where item.Sku == "D"
                              select item;

                    myShoppingList.Add(new Item {
                        Id = up3.ToList()[0].Id
                      , Sku = up3.ToList()[0].Sku
                      , UnitPrice = up3.ToList()[0].UnitPrice
                      , Promotion = up3.ToList()[0].Promotion
                    });
                    total += Checkout(myShoppingList);
                    Console.WriteLine(total);
                    break;
            }
        }

        private static decimal Checkout(List<Item>  myShoppingList) {
            decimal totalCost = 0;

            foreach (var i in myShoppingList) {
                totalCost += i.UnitPrice;
            }
            return totalCost;
        }
    }
}
