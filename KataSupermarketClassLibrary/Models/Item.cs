using KataSupermarketClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataSupermarketClassLibrary.Models {
    public class Item : IItem
        {
        public int Id { get; set; }
        public string Sku { get; set; }
        public int UnitPrice { get; set; }
        public string Promotion { get; set; }
    }
}
