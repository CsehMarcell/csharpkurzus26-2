using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Filtering;

public static class FilterbyName
{
    public static void FilterByName()
    {
        Console.Write("Name of the product: ");
        string? name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Product exists:");

        var inventory = ReadFile.Read();
        var Products = inventory.FindAll(p => p.Name.Equals(name));

        if (Products.Count > 0)
        {
            foreach (var product in Products)
            {
                Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
        }
        else
        {
            Console.WriteLine($"Product with name '{name}' not found in the inventory.");
        }
        InspectInventory.CallMenu();
    }
}
