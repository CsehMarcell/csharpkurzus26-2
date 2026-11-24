using System;
using System.Collections.Generic;
using System.Text;

using InventoryManager.Core.Modify;

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
            var newProduct = AddProduct.NewProduct();
            var inventory = ReadFile.Read();

            inventory.Add(newProduct);

            WriteFile.Write(inventory);
            Logger.WriteLog(new LogEntry(
                DateTimeOffset.Now, 
                newProduct.Id, 
                $"Added new product: {newProduct.Name}", 
                "None", 
                AddProduct.ToString(newProduct)));

            Main.CallMenu();
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
