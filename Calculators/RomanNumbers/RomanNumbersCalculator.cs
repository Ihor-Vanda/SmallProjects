using System;

namespace Calculators.RomanNumbers
{
    public class RomanNumbersCalculator : ICalculation<RomanNumber>
    {
        private RomanNumber Compute(RomanNumber firstValue, RomanNumber secondValue, Func<int, int, int> operation)
        {
            int firstArgument = RomanNumberConvertor.RomanNumberToInt(firstValue.Number);
            int secondArgument = RomanNumberConvertor.RomanNumberToInt(secondValue.Number);

            int computedResult = operation(firstArgument, secondArgument);

            string resultRoman = RomanNumberConvertor.IntToRomanNumber(computedResult);

            return new RomanNumber { Number = resultRoman };
        }

        public RomanNumber AddValues(RomanNumber firstValue, RomanNumber secondValue)
        {
            return Compute(firstValue, secondValue, (a, b) => a + b);
        }

        public RomanNumber MinusValues(RomanNumber firstValue, RomanNumber secondValue)
        {
            return Compute(firstValue, secondValue, (a, b) => a - b);
        }

        public RomanNumber MultyplyValues(RomanNumber firstValue, RomanNumber secondValue)
        {
            return Compute(firstValue, secondValue, (a, b) => a * b);
        }

        public RomanNumber DivisionValues(RomanNumber firstValue, RomanNumber secondValue)
        {
            return Compute(firstValue, secondValue, (a, b) =>
            {
                if (b == 0)
                    throw new DivideByZeroException("Can't division by zero");
                return a / b;
            });
        }
    }
}
