namespace backend_oppgave;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a temperature in Celsius:");

        string? input = Console.ReadLine();

        if(int.TryParse(input, out int temperature))
        {
            switch (temperature)
            {
                case <= 0:
                Console.WriteLine("It's freezing cold outside.");
                break;

                case > 0 and <= 15:
                Console.WriteLine("It's pretty chilly outside.");
                break;
            }
        }
    }
}
