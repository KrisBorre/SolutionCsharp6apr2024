using LibraryNumbersToWords9apr2024;
using System.Numerics;
using static System.Console;

namespace ConsoleNumbersToWords9apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 8 Exercise 8.3 page 294");
            WriteLine();

            Write("Enter a number up to twenty one digits long: ");
            string input = ReadLine();

            if (input.Length > 21)
            {
                WriteLine("I cannot handle more than twenty one digits!");
                return;
            }

            var number = BigInteger.Parse(input);

            WriteLine($"{number:N0} in words is {number.ToWords()}.");

            /*
            Enter a number up to twenty one digits long: 285
            285 in words is two hundred and eighty five.
            */

            ReadKey();
        }
    }
}
