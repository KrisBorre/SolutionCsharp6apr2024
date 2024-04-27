using LibraryPhysicalUnits6apr2024;

namespace ConsoleSnelheid6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Een chauffeur rijdt 12 kilometer in 10 minuten.");
            Console.WriteLine("Hoeveel kilometer legt hij af in een uur?");

            LengthInKilometer14feb2024 lengthInKilometer1 = new LengthInKilometer14feb2024(12, 0);

            TimeInMinutes6apr2024 timeInMinutes = new TimeInMinutes6apr2024(10, 0);

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(lengthInKilometer1.GetInKilometer() / timeInMinutes.GetInHours());

            TimeInHours6apr2024 timeInHours = new TimeInHours6apr2024(1, 0);

            LengthInKilometer14feb2024 lengthInKilometer2 = velocityInKilometerPerHour * timeInHours;

            Console.WriteLine(lengthInKilometer2.GetInKilometer()); // 72

            Console.ReadKey();
        }
    }
}
