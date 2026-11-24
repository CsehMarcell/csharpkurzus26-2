using System;
using System.Collections.Generic;
using System.Text;

using InventoryManager.Core.Filtering;

namespace InventoryManager.Core.Modify;

public static class ModifyProduct
{
    public static void Modifyproduct()
    {
        ListInventory.ListAllProducts();
        var result = FilterbyId.FilterById("ID of the product to modify: ");
        if (result == null)
        {
            
            Main.CallMenu();
        }
        else
        {
            Menus.ModifyProductMenu();
            int option = ReadInput.ReadForModifyProductMenu();

            if (option == 1)
            {
                var newProduct = ModifyName.Modifyname(result);
                Logger.WriteLog(new LogEntry(
                    DateTimeOffset.Now,
                    result.Id,
                    "Modify Name",
                    result.Name,
                    newProduct.Name
                ));
            }

            else if (option == 2)
            {
                var newProduct = ModifyQuantity.Modifyquantity(result);
                Logger.WriteLog(new LogEntry(
                    DateTimeOffset.Now,
                    result.Id,
                    "Modify Quantity",
                    result.ToString(result.Quantity),
                    newProduct.ToString(newProduct.Quantity)
                ));
            }

            else if (option == 3)
            {
                var newProduct = ModifyPrice.Modifyprice(result); 
                Logger.WriteLog(new LogEntry(
                    DateTimeOffset.Now,
                    result.Id,
                    "Modify Price",
                    result.ToString(result.Price),
                    newProduct.ToString(newProduct.Price)
                ));
            }
            else if (option == 0)
            {
                Main.CallMenu();
            }
        }
        Main.CallMenu();
    }
}
