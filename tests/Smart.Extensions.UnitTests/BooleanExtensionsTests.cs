using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(BooleanExtensions))]
public class BooleanExtensionsTests
{
    [Theory]
    [InlineData(true, 1)]
    [InlineData(false, 0)]
    public void ToInt_WhenCalled_ShouldReturnExpectedResult(bool value, int expected)
    {
        // act
        var actual = value.ToInt();
        
        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(true, "Yes")]
    [InlineData(false, "No")]
    public void ToYesNo_WhenCalled_ShouldReturnExpectedResult(bool value, string expected)
    {
        // act
        var actual = value.ToYesNo();
        
        // assert
        Assert.Equal(expected, actual);
    }
}