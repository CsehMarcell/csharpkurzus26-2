using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Filtering;

internal class FilterMin
{
    public static void FilterByMin()
    {
        var inventory = ReadFile.Read();
        var minProduct = inventory.OrderBy(p => p.Price).FirstOrDefault();

        if (minProduct != null)
        {
            Console.WriteLine();
            Console.WriteLine("Product with minimum price:");
            Console.WriteLine($"Name: {minProduct.Name}, ID: {minProduct.Id}, Quantity: {minProduct.Quantity}, Price: {minProduct.Price}");
        }
        else
        {
            Console.WriteLine("No products found in the inventory.");
        }

        InspectInventory.CallMenu();
    }
}
