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

    public Product()
    {
        Name = string.Empty;
        Id = 0;
        Quantity = 0;
        Price = 0;
    }

    public Product(string name, int id, int quantity, decimal price)
    {
        Name = name;
        Id = id;
        Quantity = quantity;
        Price = price;
    }

    public string ToString(int quantity)
    {
        return $"{quantity}";
    }
    public string ToString(decimal price)
    {
        return $"{price}";
    }
}
