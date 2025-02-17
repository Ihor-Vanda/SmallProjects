using System.Text.RegularExpressions;

namespace Calculators.RomanNumbers
{
    public partial class RomanNumber
    {
        private static readonly Regex _romanRegex = MyRegex();

        private string? _number;

        public string Number
        {
            get => _number;
            set
            {
                string normalizedValue = value?.ToUpperInvariant() ?? string.Empty;
                if (!IsCorrectRomanNumber(normalizedValue))
                {
                    throw new ArgumentException("Некоректне римське число.", nameof(value));
                }
                _number = normalizedValue;
            }
        }

        private bool IsCorrectRomanNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            return _romanRegex.IsMatch(s);
        }

        [GeneratedRegex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$", RegexOptions.IgnoreCase | RegexOptions.Compiled, "uk-UA")]
        private static partial Regex MyRegex();
    }
}