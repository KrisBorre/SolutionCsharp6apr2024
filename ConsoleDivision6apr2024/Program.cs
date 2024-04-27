using static System.Console;

namespace ConsoleDivision6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 3 Exercise 3.3 page 106");
            WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Write("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Write("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Write("Fizz");
                }
                else
                {
                    Write(i);
                }

                // put a comma and space after every number except 100
                if (i < 100) Write(", ");

                // write a carriage-return after every ten numbers
                if (i % 10 == 0) WriteLine();
            }
            WriteLine();


            /*
            1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz,
            11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz,
            Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz,
            31, 32, Fizz, 34, Buzz, Fizz, 37, 38, Fizz, Buzz,
            41, Fizz, 43, 44, FizzBuzz, 46, 47, Fizz, 49, Buzz,
            Fizz, 52, 53, Fizz, Buzz, 56, Fizz, 58, 59, FizzBuzz,
            61, 62, Fizz, 64, Buzz, Fizz, 67, 68, Fizz, Buzz,
            71, Fizz, 73, 74, FizzBuzz, 76, 77, Fizz, 79, Buzz,
            Fizz, 82, 83, Fizz, Buzz, 86, Fizz, 88, 89, FizzBuzz,
            91, 92, Fizz, 94, Buzz, Fizz, 97, 98, Fizz, Buzz
            */

            ReadKey();
        }
    }
}
