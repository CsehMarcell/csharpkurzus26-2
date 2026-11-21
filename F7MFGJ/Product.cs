using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public class Product
{
    public string Name { get; set; }
    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public Product(string name, int id, int quantity, decimal price)
    {
        Name = name;
        Id = id;
        Quantity = quantity;
        Price = price;
    }
}
