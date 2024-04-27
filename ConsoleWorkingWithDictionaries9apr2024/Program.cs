using static System.Console;

namespace ConsoleWorkingWithDictionaries9apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 8");
            WriteLine();

            var keywords = new Dictionary<string, string>();
            keywords.Add("int", "32-bit integer data type");
            keywords.Add("long", "64-bit integer data type");
            keywords.Add("float", "Single precision floating point number");

            WriteLine("Keywords and their definitions");
            foreach (KeyValuePair<string, string> item in keywords)
            {
                WriteLine($"  {item.Key}: {item.Value}");
            }
            WriteLine($"The definition of long is {keywords["long"]}");

            ReadKey();
        }
    }
}
