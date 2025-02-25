using System.Collections.Concurrent;

namespace ThreadSafeSingleton.Tests;

public class SingletonTests
{
    [Fact]
    public void Instance_IsNotNull()
    {
        // Act
        var instance = Singleton.Instance;

        // Assert
        Assert.NotNull(instance);
    }

    [Fact]
    public void Instance_ReturnsSameInstance_OnMultipleCalls()
    {
        // Act
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

        // Assert
        Assert.Same(instance1, instance2);
    }

    [Fact]
    public void Instance_IsThreadSafe()
    {
        // Arrange
        const int numberOfTasks = 100;
        var instances = new ConcurrentBag<Singleton>();

        // Act
        Parallel.For(0, numberOfTasks, i =>
        {
            instances.Add(Singleton.Instance);
        });

        // Assert
        var firstInstance = Singleton.Instance;
        foreach (var instance in instances)
        {
            Assert.Same(firstInstance, instance);
        }
    }
}
