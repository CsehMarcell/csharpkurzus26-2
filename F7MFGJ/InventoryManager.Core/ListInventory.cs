using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public static class ListInventory
{
    public static void ListAllProducts()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Current inventory:");
        var inventory = ReadFile.Read();
        foreach (var product in inventory)
        {
            Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");
        }
        Console.WriteLine();
        Console.WriteLine($"Stock on hand: {inventory.Count} Units");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        
    }
}
