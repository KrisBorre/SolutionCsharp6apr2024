namespace LibraryPhysicalUnits6apr2024
{
    public class VelocityInKilometerPerHour6apr2024 : IVelocity6apr2024
    {
        private double m_VelocityInKilometerPerHour;
        private double m_PrecisionInKilometerPerHour;

        public override string ToString()
        {
            return m_VelocityInKilometerPerHour + " km/h";
        }

        public VelocityInKilometerPerHour6apr2024(double velocityInKilometerPerHour, double precisionInKilometerPerHour = 0)
        {
            m_VelocityInKilometerPerHour = velocityInKilometerPerHour;
            m_PrecisionInKilometerPerHour = precisionInKilometerPerHour;
        }

        public double GetInMeterPerSecond()
        {
            return VelocityCalculation6apr2024.ConvertKilometerPerHourIntoMeterPerSecond(m_VelocityInKilometerPerHour);
        }

        public double GetInKilometerPerHour()
        {
            return m_VelocityInKilometerPerHour;
        }

        public double GetPrecisionInMeterPerSecond()
        {
            return VelocityCalculation6apr2024.ConvertKilometerPerHourIntoMeterPerSecond(m_PrecisionInKilometerPerHour);
        }

        public double GetPrecisionInKilometerPerHour()
        {
            return m_PrecisionInKilometerPerHour;
        }

        public static LengthInKilometer14feb2024 operator *(VelocityInKilometerPerHour6apr2024 velocity1, ITime6apr2024 time2)
        {
            var result = LengthCalculation14feb2024.Multiply(velocity1, time2);
            return new LengthInKilometer14feb2024(result.GetInKilometer(), 0);
        }

        public static LengthInKilometer14feb2024 operator *(ITime6apr2024 time1, VelocityInKilometerPerHour6apr2024 velocity2)
        {
            var result = LengthCalculation14feb2024.Multiply(time1, velocity2);
            return new LengthInKilometer14feb2024(result.GetInKilometer(), 0);
        }
    }
}
