using System;

namespace backend_oppgave;

internal static class HeaderPrinter
{
    internal static void PrintHeader()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=================================");
        Console.WriteLine("   Temperature Advisor 6000   ");
        Console.WriteLine("=================================");
        Console.ResetColor();

        DateTimePrinter.PrintDateTime();
    }
}