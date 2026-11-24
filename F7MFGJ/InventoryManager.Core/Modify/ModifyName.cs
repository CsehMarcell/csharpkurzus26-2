using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Modify;

public class ModifyName
{
    public static Product? Modifyname(Product result)
    {

        Console.Write($"Current name: {result.Name}. Enter new name: ");
        string? Name = Console.ReadLine();

        var inventory = ReadFile.Read();

        Product newProduct = new Product();

        foreach (var product in inventory)
        {
            if (product.Id == result.Id)
            {
                product.Name = Name;

                Console.WriteLine();
                Console.WriteLine($"Product name updated to: {Name}");

                WriteFile.Write(inventory);

                newProduct = product;
                break;
            }
        }
        return newProduct;
    }
}
