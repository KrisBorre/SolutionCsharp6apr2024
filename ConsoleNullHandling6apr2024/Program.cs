namespace ConsoleNullHandling6apr2024
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            Console.WriteLine("Chapter 2");
            Console.WriteLine();

            int thisCannotBeNull = 4;
            //thisCannotBeNull = null; // compile error!

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

            Console.ReadKey();
        }
    }
}
