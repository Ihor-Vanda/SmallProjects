namespace FibonacciSequence.Tests;

public class FibonacciNumbersTests
{
    [Theory]
    [InlineData(-1)]
    public void GetNumbers_InvalidCount_ThrowsArgumentException(int count)
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => FibonacciNumbers.GetNumbers(count));
    }

    [Fact]
    public void GetNumbers_Count1_ReturnsListWithZero()
    {
        // Arrange
        int endIndex = 0;

        // Act
        List<int> result = FibonacciNumbers.GetNumbers(endIndex);

        // Assert
        Assert.Single(result);
        Assert.Equal(0, result[0]);
    }

    [Fact]
    public void GetNumbers_Count2_ReturnsListWithZeroAndOne()
    {
        // Arrange
        int endIndex = 1;

        // Act
        List<int> result = FibonacciNumbers.GetNumbers(endIndex);

        // Assert
        var expected = new List<int> { 0, 1 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetNumbers_Count3_ReturnsCorrectFibonacciSequence()
    {
        // Arrange
        int endIndex = 2;

        // Act
        List<int> result = FibonacciNumbers.GetNumbers(endIndex);

        // Assert
        var expected = new List<int> { 0, 1, 1 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetNumbers_Count10_ReturnsCorrectFibonacciSequence()
    {
        // Arrange
        int endIndex = 9;

        // Act
        List<int> result = FibonacciNumbers.GetNumbers(endIndex);

        // Assert
        var expected = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
        Assert.Equal(expected, result);
    }
}
