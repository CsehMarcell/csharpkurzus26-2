using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core.Filtering;

public class InspectUsingFilter
{
    public static void InspectByFilter()
    {
        Menus.FilterMenu();
        var filterOption = ReadInput.ReadForFilterMenu();

        if (filterOption == 0)
        {
            Main.CallMenu();
        }
        else if (filterOption == 1)
        {
            FilterbyName.FilterByName();
        }
        else if (filterOption == 2)
        {
            FilterbyId.FilterById("ID of the product: ");
            InspectInventory.CallMenu();
        }
        else if (filterOption == 3)
        {
            FiltertbyQuantity.FilterByQuantity();
        }
        else if (filterOption == 4)
        {
            FilterbyPrice.FilterByPrice();
        }
        else if (filterOption == 5)
        {
            FilterMax.FilterByMax();
        }
        else if (filterOption == 6)
        {
            FilterMin.FilterByMin();
        }
    }
}
