using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public static class WriteFile
{
    public static void Write(List<Product> inventory)
    {
        var outputLines = new List<string>();

        foreach (var product in inventory)
        {
            outputLines.Add($"{product.Name};{product.Id};{product.Quantity};{product.Price}");
        }

        File.WriteAllLines(ReadFile.InventoryPath, outputLines);
    }
}
