using static System.Console;

namespace ConsoleShape8apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 6 Exercise 6.2 page 222");
            WriteLine();

            var r = new Rectangle(3, 4.5);
            WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}");

            var s = new Square(5);
            WriteLine($"Square    H: {s.Height}, W: {s.Width}, Area: {s.Area}");

            var c = new Circle(2.5);
            WriteLine($"Circle    H: {c.Height}, W: {c.Width}, Area: {c.Area}");

            ReadKey();
        }
    }
}
