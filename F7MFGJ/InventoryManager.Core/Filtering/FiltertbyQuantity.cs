using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Filtering;

internal class FiltertbyQuantity
{
    public static void FilterByQuantity()
    {
        Console.Write("Specify the set in which to search(x>number or x<number): ");
        string? filter = Console.ReadLine();

        var inventory = ReadFile.Read();

        Console.WriteLine();
        Console.WriteLine("Product exists:");

        try
        {
            int number = FilterForQP.Filter(filter);
            if (filter.Contains('<'))
            {

                var filetredProducts = inventory.Where(p => p.Quantity < number).ToList();
                foreach (var product in filetredProducts)
                {
                    Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");
                }
                Console.WriteLine();
                Console.WriteLine($"Stock on hand: {filetredProducts.Count} Units");
            }

            else if (filter.Contains('>'))
            {
                var filetredProducts = inventory.Where(p => p.Quantity > number).ToList();
                foreach (var product in filetredProducts)
                {
                    Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");
                }
                Console.WriteLine();
                Console.WriteLine($"Stock on hand: {filetredProducts.Count} Units");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid filter format. Please use the format x>number or x<number.");
        }
        finally
        {
            InspectInventory.CallMenu();
        }
    }
}
