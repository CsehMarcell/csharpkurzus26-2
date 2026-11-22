using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Filtering;

internal class FilterForQP
{
    public static int Filter(string input)
    {
        if (input.Contains('<'))
        {
            var parts = input.Split('<');
            return int.Parse(parts[1]);
        }

        else if (input.Contains('>'))
        {
            var parts = input.Split('>');
            return int.Parse(parts[1]);
        }
        else
        {
            throw new FormatException("Invalid filter input");
        }
    }
}
