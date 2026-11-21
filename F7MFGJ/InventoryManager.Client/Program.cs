using System;
using System.Collections.Generic;
using System.IO;
using InventoryManager.Core;

namespace InventoryManager.Client;

public class Program
{
    public static void Main()
    {
        var products = ReadFile.Read("inventory.csv");

        Entry.Start();






    }
}
    