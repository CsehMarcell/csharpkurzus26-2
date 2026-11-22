using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public static class Main
{
    
    public static void CallMenu()
    {
        Menus.MainMenu();
        int result = ReadInput.ReadForMainMenu();


        if (result == 0)
        {
            Console.WriteLine("Exiting the program.");
            Environment.Exit(0);
        }
        else if (result == 1)
        {
            InspectInventory.CallMenu();

        }
        else if (result == 2)
        {
            ModifyProduct.Modifyproduct();
        }
        else if (result == 3)
        {
            Console.WriteLine("Adding a product...");
            // Call the method to add a product here
        }
        else if (result == 4)
        {
            Console.WriteLine("Removing a product...");
            // Call the method to remove a product here
        }
        else if (result == 5)
        {
            Console.WriteLine("Viewing inventory logs...");
            // Call the method to view inventory logs here
        }
    }
}
