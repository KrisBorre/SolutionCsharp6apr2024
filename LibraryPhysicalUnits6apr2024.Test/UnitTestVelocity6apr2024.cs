namespace LibraryPhysicalUnits6apr2024.Test
{
    public class UnitTestVelocity6apr2024
    {
        [Fact]
        public void Test1()
        {
            double time1 = 1;
            double time2 = TimeCalculation6apr2024.ConvertHoursIntoSeconds(time1);
            Assert.Equal(expected: 3600, actual: time2);

            double value1 = 5;
            double value2 = LengthCalculation14feb2024.ConvertKilometerIntoMeter(value1);
            Assert.Equal(expected: 5000, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value1 / time1);
            VelocityInMeterPerSecond6apr2024 velocity2 = new VelocityInMeterPerSecond6apr2024(value2 / time2);

            double result = VelocityCalculation6apr2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());

            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test2()
        {
            double time1 = 1;
            double time2 = TimeCalculation6apr2024.ConvertHoursIntoSeconds(time1);
            Assert.Equal(expected: 3600, actual: time2);

            double value1 = 1000;
            double value2 = LengthCalculation14feb2024.ConvertMeterIntoKilometer(value1);
            Assert.Equal(expected: 1, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value2 / time1);
            VelocityInMeterPerSecond6apr2024 velocity2 = new VelocityInMeterPerSecond6apr2024(value1 / time2);

            double result = VelocityCalculation6apr2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());

            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test3()
        {
            double time1 = 3600;
            double time2 = TimeCalculation6apr2024.ConvertSecondsIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);

            double value1 = 5;
            double value2 = LengthCalculation14feb2024.ConvertKilometerIntoMeter(value1);
            Assert.Equal(expected: 5000, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value1 / time2);
            VelocityInMeterPerSecond6apr2024 velocity2 = new VelocityInMeterPerSecond6apr2024(value2 / time1);

            double result = VelocityCalculation6apr2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());
            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test4()
        {
            double time1 = 3600;
            double time2 = TimeCalculation6apr2024.ConvertSecondsIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);

            double value1 = 1000;
            double value2 = LengthCalculation14feb2024.ConvertMeterIntoKilometer(value1);
            Assert.Equal(expected: 1, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value2 / time2);
            VelocityInMeterPerSecond6apr2024 velocity2 = new VelocityInMeterPerSecond6apr2024(value1 / time1);

            double result = VelocityCalculation6apr2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());
            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }

        [Fact]
        public void Test5()
        {
            Console.WriteLine("Een chauffeur rijdt 12 kilometer in 10 minuten.");
            Console.WriteLine("Hoeveel kilometer legt hij af in een uur?");

            LengthInKilometer14feb2024 lengthInKilometer1 = new LengthInKilometer14feb2024(12, 0);

            TimeInMinutes6apr2024 timeInMinutes = new TimeInMinutes6apr2024(10, 0);

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(lengthInKilometer1.GetInKilometer() / timeInMinutes.GetInHours());

            TimeInHours6apr2024 timeInHours = new TimeInHours6apr2024(1, 0);

            LengthInKilometer14feb2024 lengthInKilometer2 = velocityInKilometerPerHour * timeInHours;

            Assert.Equal(expected: 72, actual: lengthInKilometer2.GetInKilometer());
        }

        [Fact]
        public void Test6()
        {
            Console.WriteLine("Bereken de afstand die is afgelegd door een auto wanneer gegeven is dat zijn gemiddelde snelheid 50 km/u is en de benodigde tijd 1 uur en 20 minuten is.");

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(50);

            TimeInHours6apr2024 timeInHours1 = new TimeInHours6apr2024(1, 0);
            TimeInMinutes6apr2024 timeInMinutes2 = new TimeInMinutes6apr2024(20, 0);

            var time = timeInHours1 + timeInMinutes2;

            LengthInKilometer14feb2024 length = velocityInKilometerPerHour * time;

            Assert.Equal(expected: 66.666666, actual: length.GetInKilometer(), 0.0001);
        }

        [Fact]
        public void Test7()
        {
            Console.WriteLine("Een wielrenner fietst 60 km per uur.");
            Console.WriteLine("Hoeveel meter per seconde fietst hij ongeveer?");

            VelocityInKilometerPerHour6apr2024 velocityInKilometerPerHour = new VelocityInKilometerPerHour6apr2024(60);

            Assert.Equal(expected: 16.666666, actual: velocityInKilometerPerHour.GetInMeterPerSecond(), 0.0001);
        }

        [Theory]
        [InlineData(5, 5000)]
        [InlineData(1, 1000)]
        public void Test8(double input, double expected)
        {
            double time1 = 1;
            double time2 = TimeCalculation6apr2024.ConvertHoursIntoSeconds(time1);
            Assert.Equal(expected: 3600, actual: time2);

            double value1 = input;
            double value2 = LengthCalculation14feb2024.ConvertKilometerIntoMeter(value1);
            Assert.Equal(expected: expected, actual: value2);

            VelocityInKilometerPerHour6apr2024 velocity1 = new VelocityInKilometerPerHour6apr2024(value1 / time1);
            VelocityInMeterPerSecond6apr2024 velocity2 = new VelocityInMeterPerSecond6apr2024(value2 / time2);

            double result = VelocityCalculation6apr2024.ConvertKilometerPerHourIntoMeterPerSecond(velocity1.GetInKilometerPerHour());

            Assert.Equal(expected: velocity2.GetInMeterPerSecond(), actual: result);
        }
    }
}