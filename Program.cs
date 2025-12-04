namespace backend_oppgave;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a temperature in Celsius:\n type exit to stop program.");

            string? input = Console.ReadLine();

            if (input?.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
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
                        Console.WriteLine("It's pretty hot outside.");
                        break;

                    case > 35:
                        Console.WriteLine("It's stupid hot outside.");
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
