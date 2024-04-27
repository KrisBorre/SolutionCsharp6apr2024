using System.Text.RegularExpressions;
using static System.Console;

namespace ConsoleRegularExpressions8apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 8 Exercise 8.2 page 294");
            WriteLine();

            WriteLine("The default regular expression checks for at least one digit.");

            do
            {
                Write("Enter a regular expression (or press ENTER to use the default): ");
                string regexp = ReadLine();

                if (string.IsNullOrWhiteSpace(regexp))
                {
                    regexp = @"^\d+$";
                }

                Write("Enter some input: ");
                string input = ReadLine();

                var r = new Regex(regexp);

                WriteLine($"{input} matches {regexp}: {r.IsMatch(input)}");

                WriteLine("Press ESC to end or any key to try again.");
            }
            while (ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
