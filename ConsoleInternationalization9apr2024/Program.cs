using System.Globalization;
using static System.Console;

namespace ConsoleInternationalization9apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 8");
            WriteLine();

            CultureInfo globalization = CultureInfo.CurrentCulture;
            CultureInfo localization = CultureInfo.CurrentUICulture;

            WriteLine("The current globalization culture is {0}: {1}", globalization.Name, globalization.DisplayName);
            WriteLine("The current localization culture is {0}: {1}", localization.Name, localization.DisplayName);
            WriteLine();

            WriteLine("en-US: English (United States)");
            WriteLine("da-DK: Danish (Denmark)");
            WriteLine("fr-CA: French (Canada)");
            Write("Enter an ISO culture code: ");
            string newCulture = ReadLine();
            if (!string.IsNullOrEmpty(newCulture))
            {
                var ci = new CultureInfo(newCulture);
                CultureInfo.CurrentCulture = ci;
                CultureInfo.CurrentUICulture = ci;
            }
            WriteLine();

            // prompt for information

            Write("Enter your name: ");
            string name = ReadLine();
            Write("Enter your date of birth: ");
            string dob = ReadLine();
            Write("Enter your salary: ");
            string salary = ReadLine();

            // parse into appropriate data types

            DateTime date = DateTime.Parse(dob);
            int minutes = (int)DateTime.Today.Subtract(date).TotalMinutes;
            decimal earns = decimal.Parse(salary);

            // write data using current culture

            WriteLine($"{name} was born on a {date:dddd}, is {minutes:N0} minutes old, and earns {earns:C}");

            ReadKey();
        }
    }
}
