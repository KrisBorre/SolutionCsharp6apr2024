using static System.Console;

namespace ConsoleFomatting6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 2");
            WriteLine();

            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            // 12 apples costs 4,20 ?

            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            //WriteToFile(formatted); // writes the string into a file

            WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            // 12 apples costs 4,20 ?

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count");

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount);

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount);

            // Name      Count
            // Apples    1 234
            // Bananas  56 789

            Write("Type your first name and press ENTER: ");
            string firstName = ReadLine();

            Write("Type your age and press ENTER: ");
            string age = ReadLine();

            WriteLine($"Hello {firstName}, you look good for {age}.");

            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                 arg0: key.Key,
                 arg1: key.KeyChar,
                 arg2: key.Modifiers);

            // Press any key combination: f
            // Key: F, Char: f, Modifiers: Alt
        }
    }
}

