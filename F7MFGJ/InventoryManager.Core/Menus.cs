using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public static class Menus
{
    public static void MainMenu()
    {
        
        Console.WriteLine();
        Console.WriteLine("Welcome to the Inventory Manager!");
        Console.WriteLine("1. Inspect inventory");
        Console.WriteLine("2. Modify products");
        Console.WriteLine("3. Add Product");
        Console.WriteLine("4. Remove Product");
        Console.WriteLine("5. QUIT and Show inventory Logs");
        Console.WriteLine("0. QUIT");
        Console.WriteLine();
        
    }

    public static void InspectInventoryMenu()
    {
        
        Console.WriteLine();
        Console.WriteLine("How would you like to inspect?");
        Console.WriteLine("1. List all products");
        Console.WriteLine("2. Inspect using filter");
        Console.WriteLine("0. Back to Main Menu");
        Console.WriteLine();
        
    }
    public static void FilterMenu()
    {
        Console.WriteLine("What filter would you like to use?");
        Console.WriteLine("1. Inspect by name");
        Console.WriteLine("2. Inspect by ID");
        Console.WriteLine("3. Inspect by quantity");
        Console.WriteLine("4. Inspect by price");
        Console.WriteLine("5. Inspect product with maximum price");
        Console.WriteLine("6. Inspect product with minimum price");
        Console.WriteLine("0. Back to Main Menu");
    }

    public static void ModifyProductMenu()
    {
        Console.WriteLine("What would you like to modify?");
        Console.WriteLine("1. Modify product name");
        Console.WriteLine("2. Modify product quantity");
        Console.WriteLine("3. Modify product price");
        Console.WriteLine("0. Back to Main Menu");
    }
}
