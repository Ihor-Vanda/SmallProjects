namespace CheckByDublicates.Tests;

public class CheckDuplicatesTests
{
    #region IsCollectionHaveDuplicates Tests

    [Fact]
    public void IsCollectionHaveDuplicates_NullOrEmpty_ThrowsArgumentException()
    {
        // Arrange
        List<int> nullCollection = null;
        List<int> emptyCollection = new List<int>();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => CheckDuplicates<int>.IsCollectionHaveDuplicates(nullCollection));
        Assert.Throws<ArgumentException>(() => CheckDuplicates<int>.IsCollectionHaveDuplicates(emptyCollection));
    }

    [Fact]
    public void IsCollectionHaveDuplicates_NoDuplicates_ReturnsFalse()
    {
        // Arrange
        var collection = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        bool hasDuplicates = CheckDuplicates<int>.IsCollectionHaveDuplicates(collection);
        bool myHasDuplicates = CheckDuplicates<int>.MyIsCollectionHaveDuplicates(collection);

        // Assert
        Assert.False(hasDuplicates);
        Assert.False(myHasDuplicates);
    }

    [Fact]
    public void IsCollectionHaveDuplicates_WithDuplicates_ReturnsTrue()
    {
        // Arrange
        var collection = new List<int> { 1, 2, 3, 2, 4 };

        // Act
        bool hasDuplicates = CheckDuplicates<int>.IsCollectionHaveDuplicates(collection);
        bool myHasDuplicates = CheckDuplicates<int>.MyIsCollectionHaveDuplicates(collection);

        // Assert
        Assert.True(hasDuplicates);
        Assert.True(myHasDuplicates);
    }

    #endregion

    #region RemoveDuplicates Tests

    [Fact]
    public void RemoveDuplicates_NullOrEmpty_ThrowsArgumentException()
    {
        // Arrange
        List<int> nullCollection = null;
        List<int> emptyCollection = new List<int>();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => CheckDuplicates<int>.RemoveDuplicates(nullCollection));
        Assert.Throws<ArgumentException>(() => CheckDuplicates<int>.RemoveDuplicates(emptyCollection));
    }

    [Fact]
    public void RemoveDuplicates_NoDuplicates_ReturnsSameCollection()
    {
        // Arrange
        var collection = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        var result = CheckDuplicates<int>.RemoveDuplicates(collection);
        var myResult = CheckDuplicates<int>.MyRemoveDuplicates(collection);

        // Assert
        Assert.Equal(collection, result);
        Assert.Equal(collection, myResult);
    }

    [Fact]
    public void RemoveDuplicates_WithDuplicates_ReturnsUniqueCollection()
    {
        // Arrange
        var collection = new List<int> { 1, 2, 3, 2, 4, 1 };
        var expected = new List<int> { 1, 2, 3, 4 };

        // Act
        var result = CheckDuplicates<int>.RemoveDuplicates(collection);
        var myResult = CheckDuplicates<int>.MyRemoveDuplicates(collection);

        // Assert
        Assert.Equal(expected.Count, result.Count());
        Assert.Equal(expected.Count, myResult.Count());
        foreach (var item in expected)
        {
            Assert.Contains(item, result);
            Assert.Contains(item, myResult);
        }
    }

    #endregion
}