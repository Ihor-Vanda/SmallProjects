namespace DirectoriesSort.Tests;

public class DirectorySorterTests : IDisposable
{
    private readonly string _tempDirectory;

    public DirectorySorterTests()
    {
        _tempDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        Directory.CreateDirectory(_tempDirectory);
    }

    public void Dispose()
    {
        if (Directory.Exists(_tempDirectory))
        {
            Directory.Delete(_tempDirectory, recursive: true);
        }
    }

    [Fact]
    public void GetSortedDirectories_SortsByNameAscending()
    {
        // Arrange
        Directory.CreateDirectory(Path.Combine(_tempDirectory, "B"));
        Directory.CreateDirectory(Path.Combine(_tempDirectory, "A"));
        Directory.CreateDirectory(Path.Combine(_tempDirectory, "C"));

        // Act
        var sortedDirs = DirectorySorter.GetSortedDirectories(_tempDirectory, d => d.Name, descending: false).ToList();

        // Assert
        Assert.Equal(3, sortedDirs.Count);
        Assert.Equal("A", sortedDirs[0].Name);
        Assert.Equal("B", sortedDirs[1].Name);
        Assert.Equal("C", sortedDirs[2].Name);
    }

    [Fact]
    public void GetSortedDirectories_SortsByCreationTimeDescending()
    {
        // Arrange
        var dir1 = Directory.CreateDirectory(Path.Combine(_tempDirectory, "Dir1"));
        var dir2 = Directory.CreateDirectory(Path.Combine(_tempDirectory, "Dir2"));
        var dir3 = Directory.CreateDirectory(Path.Combine(_tempDirectory, "Dir3"));

        DateTime time1 = DateTime.Now.AddMinutes(-30);
        DateTime time2 = DateTime.Now.AddMinutes(-20);
        DateTime time3 = DateTime.Now.AddMinutes(-10);

        Directory.SetCreationTime(dir1.FullName, time1);
        Directory.SetCreationTime(dir2.FullName, time2);
        Directory.SetCreationTime(dir3.FullName, time3);

        // Act
        var sortedDirs = DirectorySorter.GetSortedDirectories(_tempDirectory, d => d.CreationTime, descending: true).ToList();

        // Assert
        Assert.Equal(3, sortedDirs.Count);
        Assert.Equal("Dir3", sortedDirs[0].Name);
        Assert.Equal("Dir2", sortedDirs[1].Name);
        Assert.Equal("Dir1", sortedDirs[2].Name);
    }

    [Fact]
    public void GetSortedDirectories_ReturnsEmptyWhenNoDirectories()
    {
        // Arrange
        Assert.Empty(Directory.GetDirectories(_tempDirectory));

        // Act
        var sortedDirs = DirectorySorter.GetSortedDirectories(_tempDirectory, d => d.Name).ToList();

        // Assert
        Assert.Empty(sortedDirs);
    }
}
