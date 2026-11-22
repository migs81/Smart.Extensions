using System.Globalization;
using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(DateTimeExtensions))]
public class DateTimeExtensionsTest
{
    #region IsWeekend

    [Theory]
    [InlineData("31.05.2026")]
    [InlineData("30.05.2026")]
    public void IsWeekend_ValidInput_ShouldReturnTrue(string value)
    {
        // arrange
        var date = DateTime.Parse(value, new CultureInfo("de-DE"));
        
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
        var date = DateTime.Parse(value, new CultureInfo("de-DE"));
        
        // act
        var result = date.IsWeekend();
        
        // assert
        Assert.False(result);
    }
    
    #endregion

    #region IsWeekday

    [Theory]
    [InlineData("29.05.2026")]
    [InlineData("28.05.2026")]
    public void IsWeekday_ValidInput_ShouldReturnTrue(string value)
    {
        // arrange
        var date = DateTime.Parse(value, new CultureInfo("de-DE"));
        
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
        var date = DateTime.Parse(value, new CultureInfo("de-DE"));
        
        // act
        var result = date.IsWeekday();
        
        // assert
        Assert.False(result);
    }

    #endregion

    #region IsBetween

    [Fact]
    public void IsBetween_ValidDateInput_ShouldReturnTrue()
    {
        // arrange
        var date1 = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        var date2 = new DateTime(2000, 1, 2, 0, 0, 0, DateTimeKind.Utc);
        var date3 = new DateTime(2000, 1, 3, 0, 0, 0, DateTimeKind.Utc);

        // act
        var result = date2.IsBetween(date1, date3);

        // assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsBetween_WrongDateInput_ShouldReturnFalse()
    {
        // arrange
        var date1 = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        var date2 = new DateTime(2000, 1, 4, 0, 0, 0, DateTimeKind.Utc);
        var date3 = new DateTime(2000, 1, 3, 0, 0, 0, DateTimeKind.Utc);

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
        var dateTime1 = new DateTime(date, new TimeOnly(1, 1, 1), DateTimeKind.Utc);
        var dateTime2 = new DateTime(date, new TimeOnly(1, 1, 2), DateTimeKind.Utc);
        var dateTime3 = new DateTime(date, new TimeOnly(1, 1, 3), DateTimeKind.Utc);

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
        var dateTime1 = new DateTime(date, new TimeOnly(1, 1, 1), DateTimeKind.Utc);
        var dateTime2 = new DateTime(date, new TimeOnly(1, 1, 4), DateTimeKind.Utc);
        var dateTime3 = new DateTime(date, new TimeOnly(1, 1, 3), DateTimeKind.Utc);

        // act
        var result = dateTime2.IsBetween(dateTime1, dateTime3, true);

        // assert
        Assert.False(result);
    }

    #endregion

    #region IsStartOfMonth

    [Theory]
    [InlineData("01.05.2026")]
    [InlineData("01.11.2026")]
    public void IsStartOfMonth_WhenIsFirstDay_ShouldReturnTrue(string value)
    {
        // arrange
        var date = DateTime.Parse(value, new CultureInfo("de-DE"));
        
        // act
        var result = date.IsStartOfMonth();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("02.05.2026")]
    [InlineData("30.05.2026")]
    public void IsStartOfMonth_WhenIsNotFirstDay_ShouldReturnFalse(string value)
    {
        // arrange
        var date = DateTime.Parse(value, new CultureInfo("de-DE"));
        
        // act
        var result = date.IsStartOfMonth();
        
        // assert
        Assert.False(result);
    }

    #endregion
    
    #region IsEndOfMonth

    [Theory]
    [InlineData("31.05.2026")]
    [InlineData("30.06.2026")]
    public void IsEndOfMonth_WhenIsFirstDay_ShouldReturnTrue(string value)
    {
        // arrange
        var date = DateTime.Parse(value, new CultureInfo("de-DE"));
        
        // act
        var result = date.IsEndOfMonth();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("01.05.2026")]
    [InlineData("17.05.2026")]
    public void IsEndOfMonth_WhenIsNotFirstDay_ShouldReturnFalse(string value)
    {
        // arrange
        var date = DateTime.Parse(value, new CultureInfo("de-DE"));
        
        // act
        var result = date.IsEndOfMonth();
        
        // assert
        Assert.False(result);
    }

    #endregion
}