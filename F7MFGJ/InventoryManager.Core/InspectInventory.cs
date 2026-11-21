using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryManager.Core;

public class InspectInventory
{
    public static void CallMenu()
    { 
        Menus.InspectInventoryMenu();
        var result = ReadInput.ReadForInspectInventoryMenu();

        if (result == 0)
        {
            Entry.Start();
        }
        else if (result == 1)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Current inventory:");
            var inventory = ReadFile.Read("inventory.csv");
            foreach (var product in inventory)
            {
                Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
            Console.WriteLine();
            Console.WriteLine($"Stock on hand: {inventory.Count} Units");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            CallMenu();

        }
        else if (result == 2)
        {
            Console.Write("Name of the product: ");

            string? name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Results:");

            var inventory = ReadFile.Read("inventory.csv");
            var Products = inventory.FindAll(p => p.Name.Equals(name));

                if (Products.Count > 0)
                {
                    foreach (var product in Products)
                    {
                        Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");
                    }
                }
                else
                {
                    Console.WriteLine($"Product with name '{name}' not found in the inventory.");
                }

            CallMenu();
        }

        else if (result == 3)
        {
            Console.Write("ID of the product: ");

            int? id = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Results:");

            var inventory = ReadFile.Read("inventory.csv");
            var product = inventory.Find(p => p.Id.Equals(id));

            if (product != null)
            {
                    Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
            else
            {
                Console.WriteLine($"Product with ID '{id}' not found in the inventory.");
            }

            CallMenu();
        }

        else if ( result == 4)
        {
            Menus.FilterMenu();
            var filterOption = ReadInput.ReadForFilterMenu();
            var inventory = ReadFile.Read("inventory.csv");

            if (filterOption == 1)
            {
                Console.Write("Specify the set in which to search(x>number or x<number): ");
                string? filter = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Results:");

                try
                {
                    int number = Filtering.Filter(filter);
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
                    CallMenu();
                }
            }

            else if (filterOption == 2)
            {
                Console.Write("Specify the set in which to search(x>number or x<number): ");
                string? filter = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Results:");

                try
                {
                    int number = Filtering.Filter(filter);
                    if (filter.Contains('<'))
                    {
                        var filetredProducts = inventory.Where(p => p.Price < number).ToList();
                        foreach (var product in filetredProducts)
                        {
                            Console.WriteLine($"Name: {product.Name}, ID: {product.Id}, Quantity: {product.Quantity}, Price: {product.Price}");   
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Stock on hand: {filetredProducts.Count} Units");
                    }
                    else if (filter.Contains('>'))
                    {
                        var filetredProducts = inventory.Where(p => p.Price > number).ToList();
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
                    CallMenu();
                }
            }
        }

        else if (result == 5)
        {
            var inventory = ReadFile.Read("inventory.csv");
            var maxProduct = inventory.OrderByDescending(p => p.Price).FirstOrDefault();

            if (maxProduct != null)
            {
                Console.WriteLine();
                Console.WriteLine("Product with maximum value:");
                Console.WriteLine($"Name: {maxProduct.Name}, ID: {maxProduct.Id}, Quantity: {maxProduct.Quantity}, Price: {maxProduct.Price}");
            }
            else
            {
                Console.WriteLine("No products found in the inventory.");
            }

            CallMenu();
        }

        else if (result == 6)
        {
            var inventory = ReadFile.Read("inventory.csv");
            var minProduct = inventory.OrderBy(p => p.Price).FirstOrDefault();

            if (minProduct != null)
            {
                Console.WriteLine();
                Console.WriteLine("Product with minimum value:");
                Console.WriteLine($"Name: {minProduct.Name}, ID: {minProduct.Id}, Quantity: {minProduct.Quantity}, Price: {minProduct.Price}");
            }
            else
            {
                Console.WriteLine("No products found in the inventory.");
            }

            CallMenu();
        }
    }
}
