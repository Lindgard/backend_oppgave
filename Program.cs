namespace backend_oppgave;

class Program
{
    static void Main(string[] args)
    {
        HeaderPrinter.PrintHeader();
        //* Selection of temperature units that you wish to base responses on.
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Select a temperature unit:");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("1 = Celsius");
        Console.WriteLine("2 = Fahrenheit");
        Console.Write("Choice: ");
        Console.ResetColor();

        string? choice = Console.ReadLine()?.Trim();
        bool useCelsius = choice == "1";

        Console.WriteLine();
        Console.WriteLine($"You selected {(useCelsius ? "Celsius" : "Fahrenheit")} mode.");
        Console.WriteLine();

        while (true)
        {
            //* Welcome-message and information about how to close the program
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Enter a temperature in {(useCelsius ? "Celsius" : "Fahreinheit")}: ");
            Console.WriteLine("type exit to stop program.");
            Console.WriteLine("---------------------------------");
            Console.ResetColor();

            //* Reading the input typed in terminal/console 
            //* and creating a variable for the input
            string? input = Console.ReadLine()?.Trim();

            //* checks if the user typed exit to close the program
            if (input?.ToLower() == "exit")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
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
                //* some UX-focus in wrapping the responses in a little bit of a frame.
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(">>>>>>>>>>>>>>RESULT<<<<<<<<<<<<<<");
                Console.WriteLine();

                DateTimePrinter.PrintDateTime();
                TemperatureSwitch.PrintTemperatureMessage(temperatureCelsius, temperatureFahrenheit);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(">>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<");
                Console.WriteLine();
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
