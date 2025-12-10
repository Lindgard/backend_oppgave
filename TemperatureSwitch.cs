namespace backend_oppgave;

internal static class TemperatureSwitch
{
    internal static void PrintTemperatureMessage(double temperatureCelsius, double temperatureFahrenheit)
    {
        switch (temperatureCelsius)
        {
            case <= 0:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"It's freezing cold outside. ({temperatureCelsius:F1}°C / {temperatureFahrenheit:F1}°F)");
                Console.ResetColor();
                break;

            case > 0 and <= 15:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"It's pretty chilly outside.({temperatureCelsius:F1}°C / {temperatureFahrenheit:F1}°F)");
                Console.ResetColor();
                break;

            case > 15 and <= 25:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The weather is mild and comfortable.({temperatureCelsius:F1}°C / {temperatureFahrenheit:F1}°F)");
                Console.ResetColor();
                break;

            case > 25 and <= 35:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"It's pretty hot, but still comfortable outside.({temperatureCelsius:F1}°C / {temperatureFahrenheit:F1}°F)");
                Console.ResetColor();
                break;

            case > 35 and <= 45:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"It's very very hot outside.({temperatureCelsius:F1}°C / {temperatureFahrenheit:F1}°F)");
                Console.ResetColor();
                break;

            case > 45:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"It's dangerous to be outside too long.({temperatureCelsius:F1}°C / {temperatureFahrenheit:F1}°F)");
                Console.ResetColor();
                break;
        }
        Console.ResetColor();
    }
}