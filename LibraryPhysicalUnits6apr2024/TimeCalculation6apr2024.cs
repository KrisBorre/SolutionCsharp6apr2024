namespace LibraryPhysicalUnits6apr2024
{
    public static class TimeCalculation6apr2024
    {
        public static double ConvertMillisecondsIntoSeconds(double time)
        {
            return time / 1000.0;
        }

        public static double ConvertSecondsIntoMilliseconds(double time)
        {
            return time * 1000.0;
        }

        public static double ConvertHoursIntoSeconds(double time)
        {
            return time * 3600.0;
        }

        public static double ConvertSecondsIntoHours(double time)
        {
            return time / 3600.0;
        }

        public static double ConvertSecondsIntoMinutes(double time)
        {
            return time / 60.0;
        }

        public static double ConvertMinutesIntoSeconds(double time)
        {
            return time * 60.0;
        }

        public static double ConvertMinutesIntoMilliseconds(double time)
        {
            return time * 60000.0;
        }

        public static double ConvertMillisecondsIntoMinutes(double time)
        {
            return time / 60000.0;
        }

        public static double ConvertHoursIntoMinutes(double time)
        {
            return time * 60.0;
        }

        public static double ConvertMinutesIntoHours(double time)
        {
            return time / 60.0;
        }

        public static double ConvertMillisecondsIntoHours(double time)
        {
            return time / 3600000.0;
        }

        public static double ConvertHoursIntoMilliseconds(double time)
        {
            return time * 3600000.0;
        }

        public static TimeInSeconds6apr2024 Add(ITime6apr2024 time1, ITime6apr2024 time2)
        {
            double accuracy = Math.Sqrt(Math.Pow(time1.GetPrecisionInSeconds(), 2) + Math.Pow(time2.GetPrecisionInSeconds(), 2));
            return new TimeInSeconds6apr2024(time1.GetInSeconds() + time2.GetInSeconds(), accuracy);
        }

        public static TimeInSeconds6apr2024 Substract(ITime6apr2024 time1, ITime6apr2024 time2)
        {
            double accuracy = Math.Sqrt(Math.Pow(time1.GetPrecisionInSeconds(), 2) + Math.Pow(time2.GetPrecisionInSeconds(), 2));
            return new TimeInSeconds6apr2024(time1.GetInSeconds() - time2.GetInSeconds(), accuracy);
        }
    }
}
