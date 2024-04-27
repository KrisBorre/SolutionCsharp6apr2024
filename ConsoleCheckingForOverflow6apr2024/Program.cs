using static System.Console;

namespace ConsoleCheckingForOverflow6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 3");
            WriteLine();

            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but I caught the exception.");
            }

            unchecked
            {
                int y = int.MaxValue + 1;

                WriteLine($"Initial value: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
            }

            /*
            Initial value: 2147483646
            After incrementing: 2147483647
            The code overflowed but I caught the exception.
            Initial value: -2147483648
            After decrementing: 2147483647
            After decrementing: 2147483646
            */

            ReadKey();
        }
    }
}
