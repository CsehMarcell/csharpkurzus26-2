using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public static class WriteFile
{
    public static void Write(List<Product> products)
    {
        var outputLines = new List<string>();

        foreach (var product in products)
        {
            outputLines.Add($"{product.Name};{product.Id};{product.Quantity};{product.Price}");
        }

        File.WriteAllLines(ReadFile.InventoryPath, outputLines);
    }
}
