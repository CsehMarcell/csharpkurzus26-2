using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Modify;

public static class ModifyPrice
{
    public static Product Modifyprice(Product result)
    {
        Console.Write($"Current Price: {result.Price}. Enter new Price: ");

        Product newProduct = new Product();

        try
        {
            decimal Price = decimal.Parse(Console.ReadLine());

            var inventory = ReadFile.Read();

            foreach (var product in inventory)
            {
                if (product.Id == result.Id)
                {
                    product.Price = Price;

                    newProduct = product;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Product Price updated to: {Price}");

            WriteFile.Write(inventory);

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            ModifyProduct.Modifyproduct();
        }
        return newProduct;
        
    }
}
