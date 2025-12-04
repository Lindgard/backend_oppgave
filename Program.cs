namespace backend_oppgave;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            //* Welcome-message and information about how to close the program
            Console.WriteLine("Enter a temperature in Celsius:\n type exit to stop program.");
            //* Reading the input typed in terminal/console 
            //* and creating a variable for the input
            string? input = Console.ReadLine();
            //* checks if the user typed exit to close the program
            if (input?.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break; //* Closes the program with a farewell-message
            }

            //* The switch looped through for the correct response
            //* depending on input converted in the TryParse to 
            //* an integer called temperature
            if (int.TryParse(input, out int temperature))
            {
                switch (temperature)
                {
                    case <= 0:
                        Console.WriteLine("It's freezing cold outside.");
                        break;

                    case > 0 and <= 15:
                        Console.WriteLine("It's pretty chilly outside.");
                        break;

                    case > 15 and <= 25:
                        Console.WriteLine("The weather is mild and comfortable.");
                        break;

                    case > 25 and <= 35:
                        Console.WriteLine("It's pretty hot, but still comfortable outside.");
                        break;

                    case > 35 and <= 45:
                        Console.WriteLine("It's very very hot outside.");
                        break;

                    case > 45:
                        Console.WriteLine("It's dangerous to be outside too long.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine(); // Adding a blank line for readability reasons
        }
    }
}
