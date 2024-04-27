using static System.Console;

namespace ConsoleBooleanOperators6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 3");
            WriteLine();

            bool a = true;
            bool b = false;

            WriteLine($"AND  | a     | b    ");
            WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
            WriteLine();
            WriteLine($"OR   | a     | b    ");
            WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            WriteLine($"XOR  | a     | b    ");
            WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");

            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");

            ReadKey();
        }

        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
