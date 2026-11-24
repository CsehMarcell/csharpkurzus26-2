using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public sealed record LogEntry(
        DateTimeOffset Timestamp,
        int ProductId,
        string Action,
        string? OldValue,
        string? NewValue);

public static class Logger
{
    public static void WriteLog(LogEntry entry)
    {
        string logLine =
            $"{entry.Timestamp:yyyy-MM-dd HH:mm:ss} - Product with ID: {entry.ProductId}, Action: {entry.Action}, Old Value: {entry.OldValue}, New Value: {entry.NewValue}, \n";

        File.AppendAllText("inventory_log.json", logLine);

        Console.WriteLine("Logging done");
    }
}
