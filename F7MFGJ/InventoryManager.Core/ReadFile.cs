using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryManager.Core;

public class ReadFile
{
    public static readonly string InventoryPath = Path.Combine(AppContext.BaseDirectory, "inventory.csv");

    public static List<Product> Read()
    {
        var products = new List<Product>();

        foreach (string line in File.ReadAllLines(InventoryPath))
        {
            var parts = line.Split(';');

            if (parts.Length != 4)
                continue;

            if (int.TryParse(parts[1], out int id) &&
                int.TryParse(parts[2], out int quantity) &&
                decimal.TryParse(parts[3], out decimal price))
            {
                products.Add(new Product(parts[0].Trim(), id, quantity, price));
            }
        }
        
        return products;
    }
}