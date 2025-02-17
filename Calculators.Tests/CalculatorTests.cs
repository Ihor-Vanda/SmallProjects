using Calculators.ArabicNumbers;

namespace Calculators.Tests;

public class CalculatorTests
{
    private readonly Calculator<int> _calculator = new();

    [Fact]
    public void AddValues_ReturnsCorrectSum()
    {
        int result = _calculator.AddValues(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void MinusValues_ReturnsCorrectDifference()
    {
        int result = _calculator.MinusValues(10, 3);
        Assert.Equal(7, result);
    }

    [Fact]
    public void MultyplyValues_ReturnsCorrectProduct()
    {
        int result = _calculator.MultyplyValues(4, 5);
        Assert.Equal(20, result);
    }

    [Fact]
    public void DivisionValues_ReturnsCorrectQuotient()
    {
        int result = _calculator.DivisionValues(20, 4);
        Assert.Equal(5, result);
    }

    [Fact]
    public void DivisionValues_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.DivisionValues(20, 0));
    }
}
