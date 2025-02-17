using Calculators.RomanNumbers;

namespace Calculators.Tests
{
    public class RomanNumbersCalculatorTests
    {
        private readonly RomanNumbersCalculator _romanCalc = new();

        [Theory]
        [InlineData("I", "I", "II")]
        [InlineData("III", "II", "V")]
        [InlineData("X", "V", "XV")]
        public void AddValues_ReturnsCorrectRomanSum(string roman1, string roman2, string expected)
        {
            var num1 = new RomanNumber { Number = roman1 };
            var num2 = new RomanNumber { Number = roman2 };

            RomanNumber result = _romanCalc.AddValues(num1, num2);

            Assert.Equal(expected, result.Number);
        }

        [Theory]
        [InlineData("V", "I", "IV")]
        [InlineData("X", "V", "V")]
        [InlineData("X", "I", "IX")]
        public void MinusValues_ReturnsCorrectRomanDifference(string roman1, string roman2, string expected)
        {
            var num1 = new RomanNumber { Number = roman1 };
            var num2 = new RomanNumber { Number = roman2 };

            RomanNumber result = _romanCalc.MinusValues(num1, num2);

            Assert.Equal(expected, result.Number);
        }

        [Theory]
        [InlineData("II", "III", "VI")]
        [InlineData("V", "VI", "XXX")]  // 5 * 6 = 30, що дорівнює XXX
        public void MultyplyValues_ReturnsCorrectRomanProduct(string roman1, string roman2, string expected)
        {
            var num1 = new RomanNumber { Number = roman1 };
            var num2 = new RomanNumber { Number = roman2 };

            RomanNumber result = _romanCalc.MultyplyValues(num1, num2);

            Assert.Equal(expected, result.Number);
        }

        [Theory]
        [InlineData("X", "II", "V")]   // 10 / 2 = 5, тобто V
        [InlineData("XX", "IV", "V")]  // 20 / 4 = 5, тобто V
        public void DivisionValues_ReturnsCorrectRomanQuotient(string roman1, string roman2, string expected)
        {
            var num1 = new RomanNumber { Number = roman1 };
            var num2 = new RomanNumber { Number = roman2 };

            RomanNumber result = _romanCalc.DivisionValues(num1, num2);

            Assert.Equal(expected, result.Number);
        }

        [Fact]
        public void MinusValues_ResultLessThanOrEqualZero_ThrowsArgumentOutOfRangeException()
        {
            // Наприклад, "V" - "X" дасть 5 - 10 = -5, що некоректно для римських чисел
            var num1 = new RomanNumber { Number = "V" };
            var num2 = new RomanNumber { Number = "X" };

            Assert.Throws<ArgumentOutOfRangeException>(() => _romanCalc.MinusValues(num1, num2));
        }
    }
}