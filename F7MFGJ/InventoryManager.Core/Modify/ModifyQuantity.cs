using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Modify;

public static class ModifyQuantity
{
    public static Product Modifyquantity(Product result)
    {
        Console.Write($"Current quantity: {result.Quantity}. Enter new quantity: ");

        Product newProduct = new Product();

        try
        {
            var inventory = ReadFile.Read();

            int Quantity = int.Parse(Console.ReadLine());

            foreach (var product in inventory)
            {
                if (product.Id == result.Id)
                {
                    product.Quantity = Quantity;

                    newProduct = product;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Product quantity updated to: {Quantity}");

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
