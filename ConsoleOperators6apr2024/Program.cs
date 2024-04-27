using static System.Console;

namespace ConsoleOperators6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 3 Exercise 3.5 page 108");
            WriteLine();

            WriteLine("int x = 3;");
            WriteLine("int y = 2 + ++x;");
            int x = 3;
            int y = 2 + ++x;
            WriteLine($"x = {x} and y = {y}");
            WriteLine();

            WriteLine("x = 3 << 2;");
            WriteLine("y = 10 >> 1;");
            x = 3 << 2;
            y = 10 >> 1;
            WriteLine($"x = {x} and y = {y}");
            WriteLine();

            WriteLine("x = 10 & 8;");
            WriteLine("y = 10 | 7;");
            x = 10 & 8;
            y = 10 | 7;
            WriteLine($"x = {x} and y = {y}");
            WriteLine();

            ReadKey();
        }
    }
}
