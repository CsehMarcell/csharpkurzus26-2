using System;
using System.Collections.Generic;
using System.IO;

using InventoryManager.Core.Filtering;

namespace InventoryManager.Core;

public static class InspectInventory
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
            ListInventory.ListAllProducts();
            CallMenu();

        }
        else if (result == 2)
        {
            InspectUsingFilter.InspectByFilter();
        }
    }
}
