using static System.Console;

namespace ConsoleFormatException6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 3 Exercise 3.4 page 107");
            WriteLine();

            Write("Enter a number between 0 and 255: ");
            string n1 = ReadLine();

            Write("Enter another number between 0 and 255: ");
            string n2 = ReadLine();

            try
            {
                byte a = byte.Parse(n1);
                byte b = byte.Parse(n2);

                var answer = a / b;

                WriteLine($"{a} divided by {b} is {answer}");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }

            /*
            Enter a number between 0 and 255: apples
            Enter another number between 0 and 255: bananas
            FormatException: The input string 'apples' was not in a correct format.
            */

            /*
            Enter a number between 0 and 255: 10
            Enter another number between 0 and 255: 3
            10 divided by 3 is 3
            */

            /*
            Enter a number between 0 and 255: 123
            Enter another number between 0 and 255: 0
            DivideByZeroException: Attempted to divide by zero.
            */

            ReadKey();
        }
    }
}
