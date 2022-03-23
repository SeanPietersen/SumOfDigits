using Xunit;

namespace SumOfDigits.Test
{
    public class SumOfDigitCalculatorTest
    {
        [Theory]
        [InlineData(16, 7)]
        [InlineData(456, 6)]

        public void DigitalRootTest(long n, int expected)
        {
            //Arrange
            ISumOfDigitCalculator digitCalculator = new SumOfDigitCalculator();

            //Act
            var actual = digitCalculator.DigitRoot(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
