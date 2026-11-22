using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Filtering;

public static class FilterMax
{
    public static void FilterByMax()
    {
        var inventory = ReadFile.Read();
        var maxProduct = inventory.OrderByDescending(p => p.Price).FirstOrDefault();

        if (maxProduct != null)
        {
            Console.WriteLine();
            Console.WriteLine("Product with maximum price:");
            Console.WriteLine($"Name: {maxProduct.Name}, ID: {maxProduct.Id}, Quantity: {maxProduct.Quantity}, Price: {maxProduct.Price}");
        }
        else
        {
            Console.WriteLine("No products found in the inventory.");
        }

        InspectInventory.CallMenu();
    }
}
