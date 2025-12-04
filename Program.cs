namespace backend_oppgave;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            //* Welcome-message and information about how to close the program
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter a temperature in Celsius:\n type exit to stop program.");
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

            //* The switch looped through for the correct response
            //* depending on input converted in the TryParse to 
            //* an integer called temperature
            if (int.TryParse(input, out int temperature))
            {
                switch (temperature)
                {
                    case <= 0:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("It's freezing cold outside.");
                        Console.ResetColor();
                        break;

                    case > 0 and <= 15:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("It's pretty chilly outside.");
                        Console.ResetColor();
                        break;

                    case > 15 and <= 25:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The weather is mild and comfortable.");
                        Console.ResetColor();
                        break;

                    case > 25 and <= 35:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("It's pretty hot, but still comfortable outside.");
                        Console.ResetColor();
                        break;

                    case > 35 and <= 45:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It's very very hot outside.");
                        Console.ResetColor();
                        break;

                    case > 45:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("It's dangerous to be outside too long.");
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
