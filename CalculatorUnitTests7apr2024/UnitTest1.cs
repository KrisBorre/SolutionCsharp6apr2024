using LibraryCalculator7apr2024;

namespace CalculatorUnitTests7apr2024
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdding2And2()
        {
            // arrange 
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            // arrange 
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert 
            Assert.Equal(expected, actual);
        }
    }
}