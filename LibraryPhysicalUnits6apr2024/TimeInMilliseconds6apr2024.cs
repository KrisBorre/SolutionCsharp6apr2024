namespace LibraryPhysicalUnits6apr2024
{
    public class TimeInMilliseconds6apr2024 : ITime6apr2024
    {
        private double m_TimeInMilliseconds;
        private double m_PrecisionInMilliseconds;

        public TimeInMilliseconds6apr2024(double timeInMilliseconds, double accuracyInMilliseconds)
        {
            m_TimeInMilliseconds = timeInMilliseconds;
            m_PrecisionInMilliseconds = accuracyInMilliseconds;
        }

        public double GetInMilliseconds()
        {
            return m_TimeInMilliseconds;
        }

        public double GetInMinutes()
        {
            return TimeCalculation6apr2024.ConvertMillisecondsIntoMinutes(m_TimeInMilliseconds);
        }

        public double GetInSeconds()
        {
            return TimeCalculation6apr2024.ConvertMillisecondsIntoSeconds(m_TimeInMilliseconds);
        }

        public double GetInHours()
        {
            return TimeCalculation6apr2024.ConvertMillisecondsIntoHours(m_TimeInMilliseconds);
        }

        public double GetPrecisionInMilliseconds()
        {
            return m_PrecisionInMilliseconds;
        }

        public double GetPrecisionInSeconds()
        {
            return TimeCalculation6apr2024.ConvertMillisecondsIntoSeconds(m_PrecisionInMilliseconds);
        }

        public double GetPrecisionInHours()
        {
            return TimeCalculation6apr2024.ConvertMillisecondsIntoHours(m_PrecisionInMilliseconds);
        }

        public override string ToString()
        {
            return m_TimeInMilliseconds + " ms";
        }

        public static TimeInSeconds6apr2024 operator +(TimeInMilliseconds6apr2024 a, TimeInMilliseconds6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }
    }
}
