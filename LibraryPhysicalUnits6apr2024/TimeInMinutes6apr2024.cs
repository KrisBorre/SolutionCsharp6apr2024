namespace LibraryPhysicalUnits6apr2024
{
    public class TimeInMinutes6apr2024 : ITime6apr2024
    {
        private double m_TimeInMinutes;
        private double m_PrecisionInMinutes;

        public TimeInMinutes6apr2024(double timeInMinutes, double accuracyInMinutes)
        {
            m_TimeInMinutes = timeInMinutes;
            m_PrecisionInMinutes = accuracyInMinutes;
        }

        public double GetInMinutes()
        {
            return m_TimeInMinutes;
        }

        public double GetInSeconds()
        {
            return TimeCalculation6apr2024.ConvertMinutesIntoSeconds(m_TimeInMinutes);
        }

        public double GetInMilliseconds()
        {
            return TimeCalculation6apr2024.ConvertMinutesIntoMilliseconds(m_TimeInMinutes);
        }

        public double GetInHours()
        {
            return TimeCalculation6apr2024.ConvertMinutesIntoHours(m_TimeInMinutes);
        }

        public double GetPrecisionInMinutes()
        {
            return m_PrecisionInMinutes;
        }

        public double GetPrecisionInSeconds()
        {
            return TimeCalculation6apr2024.ConvertMinutesIntoSeconds(m_PrecisionInMinutes);
        }

        public double GetPrecisionInMilliseconds()
        {
            return TimeCalculation6apr2024.ConvertMinutesIntoMilliseconds(m_PrecisionInMinutes);
        }

        public double GetPrecisionInHours()
        {
            return TimeCalculation6apr2024.ConvertMinutesIntoHours(m_PrecisionInMinutes);
        }

        public override string ToString()
        {
            return m_TimeInMinutes + " min";
        }

        public static TimeInSeconds6apr2024 operator +(TimeInMinutes6apr2024 a, TimeInMinutes6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }
    }
}
