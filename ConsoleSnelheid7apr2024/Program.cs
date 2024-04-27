using LibraryPhysicalUnits6apr2024;

namespace ConsoleSnelheid7apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bereken de afstand die is afgelegd door een auto wanneer gegeven is dat zijn gemiddelde snelheid 50 km/u is en de benodigde tijd 1 uur en 20 minuten is.");

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(50);

            TimeInHours6apr2024 timeInHours1 = new TimeInHours6apr2024(1, 0);
            TimeInMinutes6apr2024 timeInMinutes2 = new TimeInMinutes6apr2024(20, 0);

            var time = timeInHours1 + timeInMinutes2;

            LengthInKilometer14feb2024 length = velocityInKilometerPerHour * time;

            Console.WriteLine(length.GetInKilometer()); // 66.666666

            Console.ReadKey();
        }
    }
}
