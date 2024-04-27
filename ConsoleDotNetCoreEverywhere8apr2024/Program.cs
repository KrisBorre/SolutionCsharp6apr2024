using static System.Console;

namespace ConsoleDotNetCoreEverywhere8apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 7");
            WriteLine();

            WriteLine("I can run everywhere!");

            WriteLine($"OS Version is {Environment.OSVersion}");

            if (OperatingSystem.IsMacOS())
            {
                WriteLine("macOS");
            }
            else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
            {
                WriteLine("Windows 10");
            }

            ReadKey();
        }
    }
}
