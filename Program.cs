namespace backend_oppgave;

class Program
{
    static void Main(string[] args)
    {
        //* Selection of temperature units that you wish to base responses on.
        Console.WriteLine("Select a temperature unit:");
        Console.WriteLine("1 = Celsius");
        Console.WriteLine("2 = Fahrenheit");
        Console.Write("Choice: ");

        string? choice = Console.ReadLine()?.Trim();
        bool useCelsius = choice == "1";

        Console.WriteLine();
        Console.WriteLine($"You selected {(useCelsius ? "Celsius" : "Fahrenheit")} mode.");
        Console.WriteLine();

        while (true)
        {
            //* Welcome-message and information about how to close the program
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Enter a temperature in {(useCelsius ? "Celsius" : "Fahreinheit")}: \n type exit to stop program.");
            Console.ResetColor();
            //* Reading the input typed in terminal/console 
            //* and creating a variable for the input
            string? input = Console.ReadLine()?.Trim();
            //* checks if the user typed exit to close the program
            if (input?.ToLower() == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Goodbye!");
                Console.ResetColor();
                break; //* Closes the program with a farewell-message with a colorchange
            }

            //* Parses input into a double for giving a response.
            if (double.TryParse(input, out double temperatureInput))
            {

                double temperatureCelsius;
                double temperatureFahrenheit;

                //* converts between Fahrenheit and celsius
                if (useCelsius)
                {
                    temperatureCelsius = temperatureInput;
                    temperatureFahrenheit = (temperatureCelsius * 9.0 / 5.0) + 32;
                }
                else
                {
                    temperatureFahrenheit = temperatureInput;
                    temperatureCelsius = (temperatureInput - 32) * 5.0 / 9.0;
                }

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
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ResetColor();
            }
            Console.WriteLine(); // Adding a blank line for readability reasons
        }
    }
}
