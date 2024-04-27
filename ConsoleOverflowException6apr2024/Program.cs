using static System.Console;

namespace ConsoleOverflowException6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 3 Exercise 3.2 page 106");
            WriteLine();

            checked
            {
                try
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        WriteLine(i);
                    }
                }
                catch (OverflowException ex)
                {
                    WriteLine($"{ex.GetType()} says {ex.Message}");
                }
            }

            /*
            0
            1
            2
            .
            .
            .
            253
            254
            255
            System.OverflowException says Arithmetic operation resulted in an overflow.
            */

            // zonder checked krijgen we een eindeloze lus.

            ReadKey();
        }
    }
}
