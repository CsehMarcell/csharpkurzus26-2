using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InventoryManager.Core;

public static class OpenLog
{
    public static void OpenLogFile()
    {
        if (!File.Exists("inventory_log.json"))
        {
            Console.WriteLine("The log file does not exist.");
            return;
        }

        Process.Start(new ProcessStartInfo
        {
            FileName = "inventory_log.json",
            UseShellExecute = true
        });
    }
}
