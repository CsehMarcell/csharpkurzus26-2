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
            Console.Clear();
            InspectInventory.CallMenu();

        }
        else if (result == 2)
        {
            ModifyProduct.Modifyproduct();
        }
        else if (result == 3)
        {
            var newProduct = AddProduct.NewProduct();
            
            Logger.WriteLog(new LogEntry(
                DateTimeOffset.Now, 
                newProduct.Id, 
                $"Added new product: {newProduct.Name}", 
                "None", 
                newProduct.ToString()));

            Main.CallMenu();
        }

        else if (result == 4)
        {
            ListInventory.ListAllProducts();
            var removedProduct = RemoveProduct.Remove();

            if (removedProduct is not null)
            {
                Logger.WriteLog(new LogEntry(
                    DateTimeOffset.Now,
                    removedProduct.Id,
                    $"Removed product: {removedProduct.Name}",
                    removedProduct.ToString(),
                    "None"));
            }
            Main.CallMenu();
        }
        else if (result == 5)
        {
            OpenLog.OpenLogFile();
            Environment.Exit(0);
        }
    }
}
