using System;

namespace SumOfDigits.App
{
    public class SumOfDigitCalculator : ISumOfDigitCalculator
    {
        public int DigitalRoot(long n)
        {
            char[] arrayOfNumbers = n.ToString().ToCharArray();
            long sum = 0;

            if (arrayOfNumbers.Length > 1)
            {
                foreach (var number in arrayOfNumbers)
                {
                    double value = Char.GetNumericValue(number);
                    sum += Convert.ToInt32(value);
                }

                return DigitalRoot(sum);
            }
            else
            {
                sum = n;
                return Convert.ToInt32(sum);
            }
        }

    }
}
