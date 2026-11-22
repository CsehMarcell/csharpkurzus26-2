using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public class Product
{
    public string Name;
    public int Id;
    public int Quantity;
    public decimal Price;

    public Product(string name, int id, int quantity, decimal price)
    {
        Name = name;
        Id = id;
        Quantity = quantity;
        Price = price;
    }
}
