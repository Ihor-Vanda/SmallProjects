namespace FindMinElementInArray.Test;

public class FindMinElementInArray
{
    [Fact]
    public void GetMinElement_NullArray_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => MinOrMaxElementInArray<int>.GetMinElement(null));
    }

    [Fact]
    public void GetMinElement_EmptyArray_ThrowsArgumentException()
    {
        // Arrange
        var array = new List<int>();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MinOrMaxElementInArray<int>.GetMinElement(array));
    }

    [Fact]
    public void GetMinElement_ReturnsCorrectMinValue()
    {
        // Arrange
        var array = new List<int> { 5, 3, 8, 1, 9 };

        // Act
        int min = MinOrMaxElementInArray<int>.GetMinElement(array);

        // Assert
        Assert.Equal(1, min);
    }

    [Fact]
    public void GetMinElement_ReturnsCorrectMinValueDouble()
    {
        // Arrange
        var array = new List<double> { 5.1, 3.3, 8.2, 1.9, 1.8 };

        // Act
        var min = MinOrMaxElementInArray<double>.GetMinElement(array);

        // Assert
        Assert.Equal(1.8, min);
    }

    [Fact]
    public void GetMaxElement_ReturnsCorrectMaxValue()
    {
        // Arrange
        var array = new List<int> { 5, 3, 8, 1, 9 };

        // Act
        int max = MinOrMaxElementInArray<int>.GetMaxElement(array);

        // Assert
        Assert.Equal(9, max);
    }

    [Fact]
    public void GetMaxElement_ReturnsCorrectMaxValueDouble()
    {
        // Arrange
        var array = new List<double> { 5.1, 3.3, 8.2, 1.9, 1.8 };

        // Act
        var max = MinOrMaxElementInArray<double>.GetMaxElement(array);

        // Assert
        Assert.Equal(8.2, max);
    }

    [Fact]
    public void GetMinElementWithLINQ_ReturnsCorrectMinValue()
    {
        // Arrange
        var array = new List<int> { 10, 20, 5, 15 };

        // Act
        int min = MinOrMaxElementInArray<int>.GetMinElementWithLINQ(array);

        // Assert
        Assert.Equal(5, min);
    }

    [Fact]
    public void GetMaxElementWithLINQ_ReturnsCorrectMaxValue()
    {
        // Arrange
        var array = new List<int> { 10, 20, 5, 15 };

        // Act
        int max = MinOrMaxElementInArray<int>.GetMaxElementWithLINQ(array);

        // Assert
        Assert.Equal(20, max);
    }

    [Fact]
    public void GetMinElement_SingleElementArray_ReturnsThatElement()
    {
        // Arrange
        var array = new List<int> { 42 };

        // Act
        int min = MinOrMaxElementInArray<int>.GetMinElement(array);

        // Assert
        Assert.Equal(42, min);
    }

    [Fact]
    public void GetMaxElement_SingleElementArray_ReturnsThatElement()
    {
        // Arrange
        var array = new List<int> { 42 };

        // Act
        int max = MinOrMaxElementInArray<int>.GetMaxElement(array);

        // Assert
        Assert.Equal(42, max);
    }
}
