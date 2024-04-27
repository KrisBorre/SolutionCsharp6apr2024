namespace LibraryPhysicalUnits6apr2024
{
    public class TimeInHours6apr2024 : ITime6apr2024
    {
        private double m_TimeInHours;
        private double m_PrecisionInHours;

        public TimeInHours6apr2024(double timeInHours, double accuracyInHours)
        {
            m_TimeInHours = timeInHours;
            m_PrecisionInHours = accuracyInHours;
        }

        public double GetInHours()
        {
            return m_TimeInHours;
        }

        public double GetInMinutes()
        {
            return TimeCalculation6apr2024.ConvertHoursIntoMinutes(m_TimeInHours);
        }

        public double GetInSeconds()
        {
            return TimeCalculation6apr2024.ConvertHoursIntoSeconds(m_TimeInHours);
        }

        public double GetInMilliseconds()
        {
            return TimeCalculation6apr2024.ConvertHoursIntoMilliseconds(m_TimeInHours);
        }

        public double GetPrecisionInHours()
        {
            return m_PrecisionInHours;
        }

        public double GetPrecisionInMinutes()
        {
            return TimeCalculation6apr2024.ConvertHoursIntoMinutes(m_PrecisionInHours);
        }

        public double GetPrecisionInSeconds()
        {
            return TimeCalculation6apr2024.ConvertHoursIntoSeconds(m_PrecisionInHours);
        }

        public double GetPrecisionInMilliseconds()
        {
            return TimeCalculation6apr2024.ConvertHoursIntoMilliseconds(m_PrecisionInHours);
        }

        public override string ToString()
        {
            return m_TimeInHours + " hours";
        }

        public static TimeInSeconds6apr2024 operator +(TimeInHours6apr2024 a, TimeInHours6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds6apr2024 operator +(TimeInHours6apr2024 a, TimeInMinutes6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds6apr2024 operator +(TimeInHours6apr2024 a, TimeInSeconds6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds6apr2024 operator +(TimeInHours6apr2024 a, TimeInMilliseconds6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds6apr2024 operator +(TimeInMinutes6apr2024 a, TimeInHours6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds6apr2024 operator +(TimeInSeconds6apr2024 a, TimeInHours6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }

        public static TimeInSeconds6apr2024 operator +(TimeInMilliseconds6apr2024 a, TimeInHours6apr2024 b)
        {
            var result = TimeCalculation6apr2024.Add(a, b);
            return result;
        }

    }
}
