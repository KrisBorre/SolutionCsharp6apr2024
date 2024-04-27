namespace LibraryPhysicalUnits6apr2024.Test
{
    public class UnitTestTime6apr2024
    {
        [Fact]
        public void Test1()
        {
            ITime6apr2024 time = new TimeInSeconds6apr2024(5, 0);
            Assert.Equal(expected: 5, actual: time.GetInSeconds());
        }

        [Fact]
        public void Test2()
        {
            TimeInMilliseconds6apr2024 time = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time.GetInMilliseconds());
        }

        [Fact]
        public void Test3()
        {
            TimeInMilliseconds6apr2024 time = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time.GetInMilliseconds());
            Assert.Equal(expected: 0.002, actual: time.GetInSeconds());
        }

        [Fact]
        public void Test4()
        {
            ITime6apr2024 time = new TimeInSeconds6apr2024(5, 0);
            Assert.Equal(expected: 5, actual: time.GetInSeconds());
            Assert.Equal(expected: 5000, actual: time.GetInMilliseconds());
        }

        [Fact]
        public void Test5()
        {
            ITime6apr2024 time = new TimeInSeconds6apr2024(5, 1);
            Assert.Equal(expected: 5, actual: time.GetInSeconds(), tolerance: 1);
        }

        [Fact]
        public void Test6()
        {
            TimeInMilliseconds6apr2024 time = new TimeInMilliseconds6apr2024(2, 0.1);
            Assert.Equal(expected: 2, actual: time.GetInMilliseconds(), tolerance: 0.1);
        }

        [Fact]
        public void Test7()
        {
            ITime6apr2024 time = new TimeInSeconds6apr2024(5, 1);
            Assert.Equal(expected: 5, actual: time.GetInSeconds(), tolerance: 1);
            Assert.Equal(expected: 5000, actual: time.GetInMilliseconds(), tolerance: 1000);
        }

        [Fact]
        public void Test8()
        {
            ITime6apr2024 time1 = new TimeInSeconds6apr2024(5, 0);
            Assert.Equal(expected: 5, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation6apr2024.Add(time1, time2);

            Assert.Equal(expected: 5002, actual: totalTime.GetInMilliseconds(), tolerance: 1);
        }

        [Fact]
        public void Test9()
        {
            ITime6apr2024 time1 = new TimeInSeconds6apr2024(5, 0);
            Assert.Equal(expected: 5, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation6apr2024.Add(time1, time2);

            Assert.Equal(expected: 5.002, actual: totalTime.GetInSeconds(), tolerance: 0.001);
        }

        [Fact]
        public void Test10()
        {
            ITime6apr2024 time1 = new TimeInMilliseconds6apr2024(5, 0);
            Assert.Equal(expected: 0.005, actual: time1.GetInSeconds());

            ITime6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation6apr2024.Add(time1, time2);

            Assert.Equal(expected: 0.007, actual: totalTime.GetInSeconds(), tolerance: 0.001);
        }

        [Fact]
        public void Test11()
        {
            ITime6apr2024 time1 = new TimeInSeconds6apr2024(5, 1);
            Assert.Equal(expected: 5, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0.1);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation6apr2024.Add(time1, time2);

            Assert.Equal(expected: 5002, actual: totalTime.GetInMilliseconds(), tolerance: 1500);
        }

        [Fact]
        public void Test12()
        {
            ITime6apr2024 time1 = new TimeInSeconds6apr2024(5, 0.1);
            Assert.Equal(expected: 5, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 1);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation6apr2024.Add(time1, time2);

            Assert.Equal(expected: 5.002, actual: totalTime.GetInSeconds(), tolerance: 0.15);
        }

        [Fact]
        public void Test13()
        {
            ITime6apr2024 time1 = new TimeInMilliseconds6apr2024(5, 0.002);
            Assert.Equal(expected: 0.005, actual: time1.GetInSeconds());

            ITime6apr2024 time2 = new TimeInMilliseconds6apr2024(2, 0);
            Assert.Equal(expected: 2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation6apr2024.Add(time1, time2);

            Assert.Equal(expected: 0.007, actual: totalTime.GetInSeconds(), tolerance: 0.002);
        }

        [Fact]
        public void Test14()
        {
            double time1 = 5;
            double time2 = TimeCalculation6apr2024.ConvertMillisecondsIntoSeconds(time1);
            Assert.Equal(expected: 0.005, actual: time2);
        }


        [Fact]
        public void Test15()
        {
            double time1 = 5;
            double time2 = TimeCalculation6apr2024.ConvertSecondsIntoMilliseconds(time1);
            Assert.Equal(expected: 5000, actual: time2);
        }


        [Fact]
        public void Test16()
        {
            double time1 = 1;
            double time2 = TimeCalculation6apr2024.ConvertHoursIntoSeconds(time1);
            Assert.Equal(expected: 3600, actual: time2);
        }


        [Fact]
        public void Test17()
        {
            double time1 = 3600;
            double time2 = TimeCalculation6apr2024.ConvertSecondsIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Fact]
        public void Test18()
        {
            double time1 = 1;
            double time2 = TimeCalculation6apr2024.ConvertMinutesIntoSeconds(time1);
            Assert.Equal(expected: 60, actual: time2);
        }

        [Fact]
        public void Test19()
        {
            double time1 = 60;
            double time2 = TimeCalculation6apr2024.ConvertSecondsIntoMinutes(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Fact]
        public void Test20()
        {
            double time1 = 60000;
            double time2 = TimeCalculation6apr2024.ConvertMillisecondsIntoMinutes(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Fact]
        public void Test21()
        {
            double time1 = 1;
            double time2 = TimeCalculation6apr2024.ConvertMinutesIntoMilliseconds(time1);
            Assert.Equal(expected: 60000, actual: time2);
        }

        [Fact]
        public void Test22()
        {
            double time1 = 60;
            double time2 = TimeCalculation6apr2024.ConvertMinutesIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Fact]
        public void Test23()
        {
            double time1 = 1;
            double time2 = TimeCalculation6apr2024.ConvertHoursIntoMinutes(time1);
            Assert.Equal(expected: 60, actual: time2);
        }

        [Fact]
        public void Test24()
        {
            double time1 = 1;
            double time2 = TimeCalculation6apr2024.ConvertHoursIntoMilliseconds(time1);
            Assert.Equal(expected: 3600000, actual: time2);
        }

        [Fact]
        public void Test25()
        {
            double time1 = 3600000;
            double time2 = TimeCalculation6apr2024.ConvertMillisecondsIntoHours(time1);
            Assert.Equal(expected: 1, actual: time2);
        }

        [Theory]
        [InlineData(5, 2, 5.002)]
        [InlineData(5000, 2000, 5002)]
        [InlineData(2, 7, 2.007)]
        public void Test26(double input1, double input2, double expected)
        {
            ITime6apr2024 time1 = new TimeInSeconds6apr2024(input1, 0);
            Assert.Equal(expected: input1, actual: time1.GetInSeconds());

            TimeInMilliseconds6apr2024 time2 = new TimeInMilliseconds6apr2024(input2, 0);
            Assert.Equal(expected: input2, actual: time2.GetInMilliseconds());

            ITime6apr2024 totalTime = TimeCalculation6apr2024.Add(time1, time2);

            Assert.Equal(expected: expected, actual: totalTime.GetInSeconds(), tolerance: 0.001);
        }

        [Theory]
        [InlineData(3_600_000, 1)]
        [InlineData(900_000, 0.25)]
        public void Test27(double input, double expected)
        {
            double time1 = input;
            double time2 = TimeCalculation6apr2024.ConvertMillisecondsIntoHours(time1);
            Assert.Equal(expected: expected, actual: time2);
        }
    }
}
