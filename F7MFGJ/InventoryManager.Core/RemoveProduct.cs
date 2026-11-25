using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public static class RemoveProduct
{
    public static Product Remove()
    {
        var removedProduct = new Product();
        var inventory = ReadFile.Read();
        if (inventory == null)
        {
            Console.WriteLine("There is no product in the inventory.");
            Main.CallMenu();
        }

        Console.Write("Enter the ID of the product you want to remove (Enter to exit):");

        var ifNull = Console.ReadLine();
        if (ifNull == "")
        {
            Console.Clear();
            Main.CallMenu();
        }

        bool Pfind = false;
        try
        {
            int id = int.Parse(ifNull);

            foreach (var product in inventory)
            {
                if (product.Id == id)
                {
                    inventory.Remove(product);
                    WriteFile.Write(inventory);
                    Console.WriteLine();
                    Console.WriteLine("Product removed successfully.");
                    removedProduct = product;
                    Pfind = true;
                    break;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return Remove();
        }

        if (Pfind == true)
        {
            return removedProduct;
        }
        else
        {
            Console.WriteLine("Product not found.");
            return Remove();
        }
    }
}
