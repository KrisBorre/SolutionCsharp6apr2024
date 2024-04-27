using LibraryPhysicalUnits6apr2024;

namespace ConsoleSnelheid8apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Een wielrenner fietst 60 km per uur.");
            Console.WriteLine("Hoeveel meter per seconde fietst hij ongeveer?");

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(60);

            Console.WriteLine(velocityInKilometerPerHour.GetInMeterPerSecond()); // 16.6666

            Console.ReadKey();
        }
    }
}
