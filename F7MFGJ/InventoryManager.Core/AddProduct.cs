using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public static class AddProduct
{
    public static Product NewProduct()
    {
        int idOut;
        string? nameOut;
        int quantityOut;
        decimal priceOut;

        var inventory = ReadFile.Read();

        Console.Write("ID (Enter to exit):");

        var ifNull = Console.ReadLine();
        if (ifNull == "")
        {
            Console.Clear();
            Main.CallMenu();
        }
        else
        {
            try
            {

                int id = int.Parse(ifNull);


                foreach (var product in inventory)
                {
                    if (product.Id == id)
                    {
                        Console.WriteLine("Product with this ID already exists.");
                        return NewProduct();
                    }
                }
                idOut = id;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return NewProduct();
            }

            Console.Write("Name:");
            string name = Console.ReadLine();
            nameOut = name;

            Console.Write("Quantity:");
            try
            {
                int quantity = int.Parse(Console.ReadLine());

                quantityOut = quantity;

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return NewProduct();

            }

            Console.Write("Price:");
            try
            {
                decimal price = decimal.Parse(Console.ReadLine());

                priceOut = price;

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                return NewProduct();

            }
            inventory.Add(new Product(nameOut, idOut, quantityOut, priceOut));
            WriteFile.Write(inventory);

            foreach (var product in inventory)
            {
                if (product.Id == idOut)
                {
                    return product;
                }
            }
        }
        return null;
    }
}

