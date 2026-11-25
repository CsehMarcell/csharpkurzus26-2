using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Filtering;

internal class FilterbyId
{
    public static Product FilterById(string prompt)
    {
        Console.Write(prompt);
        var ifNull = Console.ReadLine();
        if (ifNull == "")
        {
            Console.Clear();
            Main.CallMenu();
        }
        try
        {
            int? id = int.Parse(ifNull);

            Console.WriteLine();
            Console.WriteLine("Product with matching ID:");

            var inventory = ReadFile.Read();
            var product = inventory.Find(p => p.Id.Equals(id));

            if (product != null)
            {
                Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");
                Console.WriteLine();
                return product;
            }
            else
            {
                Console.WriteLine($"Product with ID '{id}' not found in the inventory.");
            }
            return null;

        }
        catch(FormatException)
        {
            Console.WriteLine("That ID does not exist!");
            return null;
        }
    }
}
