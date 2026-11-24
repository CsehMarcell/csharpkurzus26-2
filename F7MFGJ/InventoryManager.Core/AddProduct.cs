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

        Console.Write("ID:");
        try
        {
            int id = int.Parse(Console.ReadLine());

            var inventory = ReadFile.Read();
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
        return new Product(nameOut, idOut, quantityOut, priceOut);
    }

    public static string ToString(Product product){
        if (product == null)
        {
            return "Product is null.";
        }
        return $"Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}";
    }
}

