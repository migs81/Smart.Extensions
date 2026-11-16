using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(DateTimeExtensions))]
public class DateTimeExtensionsTest
{
    [Theory]
    [InlineData("31.05.2026")]
    [InlineData("30.05.2026")]
    public void IsWeekend_ValidInput_ShouldReturnTrue(string value)
    {
        // arrange
        var date = DateTime.Parse(value);
        
        // act
        var result = date.IsWeekend();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("29.05.2026")]
    [InlineData("28.05.2026")]
    public void IsWeekend_WrongInput_ShouldReturnFalse(string value)
    {
        // arrange
        var date = DateTime.Parse(value);
        
        // act
        var result = date.IsWeekend();
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData("29.05.2026")]
    [InlineData("28.05.2026")]
    public void IsWeekday_ValidInput_ShouldReturnTrue(string value)
    {
        // arrange
        var date = DateTime.Parse(value);
        
        // act
        var result = date.IsWeekday();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("31.05.2026")]
    [InlineData("30.05.2026")]
    public void IsWeekday_WrongInput_ShouldReturnFalse(string value)
    {
        // arrange
        var date = DateTime.Parse(value);
        
        // act
        var result = date.IsWeekday();
        
        // assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsBetween_ValidDateInput_ShouldReturnTrue()
    {
        // arrange
        var date1 = new DateTime(2000, 1, 1);
        var date2 = new DateTime(2000, 1, 2);
        var date3 = new DateTime(2000, 1, 3);

        // act
        var result = date2.IsBetween(date1, date3);

        // assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsBetween_WrongDateInput_ShouldReturnFalse()
    {
        // arrange
        var date1 = new DateTime(2000, 1, 1);
        var date2 = new DateTime(2000, 1, 4);
        var date3 = new DateTime(2000, 1, 3);

        // act
        var result = date2.IsBetween(date1, date3);

        // assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsBetween_ValidDateTimeInput_ShouldReturnTrue()
    {
        // arrange
        var date = new DateOnly(2000, 1, 1);
        var dateTime1 = new DateTime(date, new TimeOnly(1, 1, 1));
        var dateTime2 = new DateTime(date, new TimeOnly(1, 1, 2));
        var dateTime3 = new DateTime(date, new TimeOnly(1, 1, 3));

        // act
        var result = dateTime2.IsBetween(dateTime1, dateTime3);

        // assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsBetween_WrongDateTimeInput_ShouldReturnFalse()
    {
        // arrange
        var date = new DateOnly(2000, 1, 1);
        var dateTime1 = new DateTime(date, new TimeOnly(1, 1, 1));
        var dateTime2 = new DateTime(date, new TimeOnly(1, 1, 4));
        var dateTime3 = new DateTime(date, new TimeOnly(1, 1, 3));

        // act
        var result = dateTime2.IsBetween(dateTime1, dateTime3, true);

        // assert
        Assert.False(result);
    }
}