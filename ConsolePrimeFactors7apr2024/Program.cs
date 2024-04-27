using LibraryPrimeFactors7apr2024;
using static System.Console;

namespace ConsolePrimeFactors7apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 4");
            WriteLine();

            Write("Enter a number between 1 and 1000: ");

            if (int.TryParse(ReadLine(), out int number))
            {
                WriteLine(format: "Prime factors of {0} are: {1}",
                  arg0: number,
                  arg1: Primes.PrimeFactors(number));
            }

            ReadKey();

            /*
            Enter a number between 1 and 1000: 100
            Prime factors of 100 are: 5 x 5 x 2 x 2
            */
        }
    }
}
