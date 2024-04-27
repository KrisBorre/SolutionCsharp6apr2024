namespace LibraryPhysicalUnits6apr2024
{
    public class VelocityCalculation6apr2024
    {
        public static double ConvertKilometerPerHourIntoMeterPerSecond(double velocity)
        {
            return velocity / 3.6;
        }

        public static double ConvertMeterPerSecondIntoKilometerPerHour(double velocity)
        {
            return velocity * 3.6;
        }

        /// <summary>
        /// Precondition: velocity1 and velocity2 are independently measured
        /// </summary>
        /// <param name="velocity1"></param>
        /// <param name="velocity2"></param>
        /// <returns></returns>
        public static VelocityInMeterPerSecond6apr2024 Add(IVelocity6apr2024 velocity1, IVelocity6apr2024 velocity2)
        {
            double accuracy = Math.Sqrt(Math.Pow(velocity1.GetPrecisionInMeterPerSecond(), 2) + Math.Pow(velocity2.GetPrecisionInMeterPerSecond(), 2));
            return new VelocityInMeterPerSecond6apr2024(velocity1.GetInMeterPerSecond() + velocity2.GetInMeterPerSecond(), accuracy);
        }

        public static VelocityInMeterPerSecond6apr2024 Substract(IVelocity6apr2024 velocity1, IVelocity6apr2024 velocity2)
        {
            double accuracy = Math.Sqrt(Math.Pow(velocity1.GetPrecisionInMeterPerSecond(), 2) + Math.Pow(velocity2.GetPrecisionInMeterPerSecond(), 2));
            return new VelocityInMeterPerSecond6apr2024(velocity1.GetInMeterPerSecond() - velocity2.GetInMeterPerSecond(), accuracy);
        }

        public static VelocityInMeterPerSecond6apr2024 Divide(ILength14feb2024 length1, ITime6apr2024 time2)
        {
            double accuracy = Math.Sqrt(Math.Pow(length1.GetPrecisionInMeter() * time2.GetInSeconds(), 2) + Math.Pow(time2.GetPrecisionInSeconds() * length1.GetInMeter(), 2));
            return new VelocityInMeterPerSecond6apr2024(length1.GetInMeter() / time2.GetInSeconds(), accuracy);
        }
    }
}
