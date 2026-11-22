using System;
using System.Collections.Generic;
using System.Text;

using InventoryManager.Core.Filtering;

namespace InventoryManager.Core;

public static class ModifyProduct
{
    public static void Modifyproduct()
    {
        ListInventory.ListAllProducts();
        var result = FilterbyId.FilterById("ID of the product to modify: ");
        if (result == null)
        {
            Main.CallMenu();
        }
        else
        {
            Menus.ModifyProductMenu();
            int option = ReadInput.ReadForModifyProductMenu();

            if (option == 1)
            {

                Console.Write($"Current name: {result.Name}. Enter new name: "); 
                result.Name = Console.ReadLine();

                var inventory = ReadFile.Read();

                foreach (var product in inventory)
                {
                    if (product.Id == result.Id)
                    {
                        product.Name = result.Name;
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Product name updated to: {result.Name}");

                WriteFile.Write(inventory);
                Main.CallMenu();

            }

            else if (option == 2)
            {
                Console.Write($"Current quantity: {result.Quantity}. Enter new quantity: ");
                try
                {
                    result.Quantity = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Modifyproduct();
                }

                var inventory = ReadFile.Read();

                foreach (var product in inventory)
                {
                    if (product.Id == result.Id)
                    {
                        product.Quantity = result.Quantity;
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Product quantity updated to: {result.Quantity}");

                WriteFile.Write(inventory);
                Main.CallMenu();

            }

            else if (option == 3)
            {
                Console.Write($"Current Price: {result.Price}. Enter new Price: ");
                try
                {
                    result.Price = decimal.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Modifyproduct();
                }

                var inventory = ReadFile.Read();

                foreach (var product in inventory)
                {
                    if (product.Id == result.Id)
                    {
                        product.Price = result.Price;
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Product Price updated to: {result.Price}");

                WriteFile.Write(inventory);
                Main.CallMenu();
            }
            else if (option == 0)
            {
                Main.CallMenu();
            }
        }

    }
}
