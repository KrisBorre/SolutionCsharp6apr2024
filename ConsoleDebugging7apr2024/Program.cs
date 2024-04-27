using static System.Console;

namespace ConsoleDebugging7apr2024
{
    internal class Program
    {
        static double Add(double a, double b)
        {
            return a + b; // deliberate bug!
        }

        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 4");
            WriteLine();

            double a = 4.5; // or use var
            double b = 2.5;
            double answer = Add(a, b);
            WriteLine($"{a} + {b} = {answer}");
            ReadLine(); // wait for user to press ENTER
        }
    }
}
