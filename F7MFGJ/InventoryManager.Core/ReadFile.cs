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

        try
        {
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
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Inventory file not found at {InventoryPath}. The inventory starts empty.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the inventory file: {ex.Message}");
        }

        return products;
    }
}