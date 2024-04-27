namespace LibraryPhysicalUnits6apr2024
{
    public class TimeInSeconds6apr2024 : ITime6apr2024
    {
        private double m_TimeInSeconds;
        private double m_PrecisionInSeconds;

        public TimeInSeconds6apr2024(double timeInSeconds, double accuracyInSeconds)
        {
            m_TimeInSeconds = timeInSeconds;
            m_PrecisionInSeconds = accuracyInSeconds;
        }

        public double GetInSeconds()
        {
            return m_TimeInSeconds;
        }

        public double GetInMilliseconds()
        {
            return TimeCalculation6apr2024.ConvertSecondsIntoMilliseconds(m_TimeInSeconds);
        }

        public double GetInMinutes()
        {
            return TimeCalculation6apr2024.ConvertSecondsIntoMinutes(m_TimeInSeconds);
        }

        public double GetInHours()
        {
            return TimeCalculation6apr2024.ConvertSecondsIntoHours(m_TimeInSeconds);
        }

        public double GetPrecisionInSeconds()
        {
            return m_PrecisionInSeconds;
        }

        public double GetPrecisionInMilliseconds()
        {
            return TimeCalculation6apr2024.ConvertSecondsIntoMilliseconds(m_PrecisionInSeconds);
        }

        public double GetPrecisionInHours()
        {
            return TimeCalculation6apr2024.ConvertSecondsIntoHours(m_PrecisionInSeconds);
        }

        public override string ToString()
        {
            return m_TimeInSeconds + " s";
        }

        public static TimeInSeconds6apr2024 operator +(TimeInSeconds6apr2024 a, TimeInSeconds6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }
    }
}
