using CheckNumerBySimple;

namespace CheckNumberBySimple.Tests;

public class CheckNumBySimpleTest
{
    [Fact]
    public void CheckNumBySimple_SimpleNumResult()
    {
        Assert.True(CheckNumbySimple.IsSimpleNum(3));
        Assert.True(CheckNumbySimple.IsSimpleNum(13));
        Assert.False(CheckNumbySimple.IsSimpleNum(12));
    }
}
