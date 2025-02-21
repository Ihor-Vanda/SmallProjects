namespace FizzBuzz.Tests;

public class FizzBuzzGameTests
{
    [Fact]
    public void Play_ValidRange_ReturnsCorrectFizzBuzzSequence()
    {
        // Arrange
        int initialNumber = 1;
        int stopNumber = 15;
        string expected = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz";

        // Act
        string result = FizzBuzzGame.Play(initialNumber, stopNumber);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 9)]
    public void Play_InvalidRange_ThrowsArgumentException(int initialNumber, int stopNumber)
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => FizzBuzzGame.Play(initialNumber, stopNumber));
    }

    [Fact]
    public void Play_RangeWithoutFizzBuzz_ReturnsNumbersSeparatedByComma()
    {
        // Arrange
        int initialNumber = 1;
        int stopNumber = 2;
        string expected = "1, 2";

        // Act
        string result = FizzBuzzGame.Play(initialNumber, stopNumber);

        // Assert
        Assert.Equal(expected, result);
    }
}
