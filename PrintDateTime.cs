namespace backend_oppgave;

internal static class DateTimePrinter
{
    internal static void PrintDateTime()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"Today is {DateTime.Now:dddd, dd, MMMM, yyyy}");
        Console.WriteLine($"Time: {DateTime.Now:HH:MM}");
        Console.ResetColor();
        Console.WriteLine();
    }
}