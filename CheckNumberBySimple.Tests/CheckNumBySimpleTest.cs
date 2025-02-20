using CheckNumerBySimple;

namespace CheckNumberBySimple.Tests;

public class CheckNumBySimpleTest
{
    [Fact]
    public void CheckNumBySimple_SimpleNumResultTrueWithMinimalsSimpleNumbers()
    {
        Assert.True(CheckNumBySimple.IsSimpleNum(3));
        Assert.True(CheckNumBySimple.IsSimpleNum(13));
        Assert.False(CheckNumBySimple.IsSimpleNum(12));
        Assert.True(CheckNumBySimple.IsSimpleNum(347));
        Assert.True(CheckNumBySimple.IsSimpleNum(571));
    }

    [Fact]
    public void CheckNumBySimple_SimpleNumResultFalse()
    {
        Assert.False(CheckNumBySimple.IsSimpleNum(12));
        Assert.False(CheckNumBySimple.IsSimpleNum(200));
    }

    [Fact]
    public void CheckNumBySimple_SimpleNumResultTrueWithHightValueSimpleNumbers()
    {
        Assert.True(CheckNumBySimple.IsSimpleNum(347));
        Assert.True(CheckNumBySimple.IsSimpleNum(571));
    }
}
