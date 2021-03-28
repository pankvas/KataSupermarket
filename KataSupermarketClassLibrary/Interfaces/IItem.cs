using System;
using System.Collections.Generic;
using System.Text;

namespace KataSupermarketClassLibrary.Interfaces {
    public interface IItem 
    {
        int Id { get; set; }
        string Sku { get; set; }
        int UnitPrice { get; set; }
        string Promotion { get; set; }
    }
}
