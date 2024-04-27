namespace LibraryPhysicalUnits6apr2024
{
    public class VelocityInMeterPerSecond6apr2024 : IVelocity6apr2024
    {
        private double m_VelocityInMeterPerSecond;
        private double m_PrecisionInMeterPerSecond;

        public override string ToString()
        {
            return m_VelocityInMeterPerSecond + " m/s";
        }

        public VelocityInMeterPerSecond6apr2024(double velocityInMeterPerSecond, double precisionInMeterPerSecond = 0)
        {
            m_VelocityInMeterPerSecond = velocityInMeterPerSecond;
            m_PrecisionInMeterPerSecond = precisionInMeterPerSecond;
        }

        public double GetInMeterPerSecond()
        {
            return m_VelocityInMeterPerSecond;
        }

        public double GetInKilometerPerHour()
        {
            return VelocityCalculation6apr2024.ConvertMeterPerSecondIntoKilometerPerHour(m_VelocityInMeterPerSecond);
        }

        public double GetPrecisionInMeterPerSecond()
        {
            return m_PrecisionInMeterPerSecond;
        }

        public double GetPrecisionInKilometerPerHour()
        {
            return VelocityCalculation6apr2024.ConvertMeterPerSecondIntoKilometerPerHour(m_PrecisionInMeterPerSecond);
        }

        public static LengthInMeter14feb2024 operator *(VelocityInMeterPerSecond6apr2024 velocity1, ITime6apr2024 time2)
        {
            var result = LengthCalculation14feb2024.Multiply(velocity1, time2);
            return result;
        }

        public static LengthInMeter14feb2024 operator *(ITime6apr2024 time1, VelocityInMeterPerSecond6apr2024 velocity2)
        {
            var result = LengthCalculation14feb2024.Multiply(time1, velocity2);
            return result;
        }


    }
}
