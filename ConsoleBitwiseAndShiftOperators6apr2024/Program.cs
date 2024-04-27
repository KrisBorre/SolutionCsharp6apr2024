using static System.Console;

namespace ConsoleBitwiseAndShiftOperators6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 3");
            WriteLine();

            int a = 10; // 0000 1010
            int b = 6;  // 0000 0110

            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}"); // 2-bit column only
            WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
            WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns

            // 0101 0000 left-shift a by three bit columns
            WriteLine($"a << 3 = {a << 3}"); // 80

            // multiply a by 8
            WriteLine($"a * 8 = {a * 8}"); // 80

            // 0000 0011 right-shift b by one bit column
            WriteLine($"b >> 1 = {b >> 1}"); // 3

            ReadKey();
        }
    }
}
