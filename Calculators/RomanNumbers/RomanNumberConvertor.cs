using System;
using System.Collections.Generic;
using System.Text;

namespace Calculators.RomanNumbers
{
    public static class RomanNumberConvertor
    {
        private static readonly Dictionary<char, int> _romanValues = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        private static readonly (int Value, string Numeral)[] _romanNumerals =
        [
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        ];

        public static int RomanNumberToInt(string romanNumber)
        {
            if (string.IsNullOrWhiteSpace(romanNumber))
                throw new ArgumentException("Number is empty.", nameof(romanNumber));

            romanNumber = romanNumber.ToUpperInvariant();
            int total = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                int currentValue = _romanValues[romanNumber[i]];

                if (i + 1 < romanNumber.Length)
                {
                    int nextValue = _romanValues[romanNumber[i + 1]];
                    if (currentValue < nextValue)
                    {
                        total -= currentValue;
                        continue;
                    }
                }

                total += currentValue;
            }

            return total;
        }

        public static string IntToRomanNumber(int number)
        {
            if (number <= 0 || number > 3999)
                throw new ArgumentOutOfRangeException(nameof(number), "The number must be in range 1 - 3999");

            var result = new StringBuilder();

            foreach (var item in _romanNumerals)
            {
                while (number >= item.Value)
                {
                    result.Append(item.Numeral);
                    number -= item.Value;
                }
            }

            return result.ToString();
        }
    }
}
