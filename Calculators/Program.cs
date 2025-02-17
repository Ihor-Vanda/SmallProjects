using Calculators.ArabicNumbers;
using Calculators.RomanNumbers;

Calculator<int> calculator = new();

Console.WriteLine(calculator.AddValues(1, 2));

Calculator<double> calculatorDouble = new();

Console.WriteLine(calculatorDouble.AddValues(1.1, 2.2));

RomanNumber a = new() { Number = "X" };
RomanNumber b = new() { Number = "V" };

RomanNumbersCalculator romanNumbersCalculator = new();

Console.WriteLine(romanNumbersCalculator.AddValues(a, b).Number);
Console.WriteLine(romanNumbersCalculator.MinusValues(a, b).Number);
Console.WriteLine(romanNumbersCalculator.MultyplyValues(a, b).Number);
Console.WriteLine(romanNumbersCalculator.DivisionValues(a, b).Number);