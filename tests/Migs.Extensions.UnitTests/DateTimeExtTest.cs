using JetBrains.Annotations;

namespace Migs.Extensions.UnitTests.DateTimes;

[TestSubject(typeof(DateTimeExt))]
public class DateTimeExtTest
{
    [Fact]
    public void IsBetween_ValidDateInput_ShouldBeTrue()
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
    public void IsBetween_WrongDateInput_ShouldBeFalse()
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
    public void IsBetween_ValidDateTimeInput_ShouldBeTrue()
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
    public void IsBetween_WrongDateTimeInput_ShouldBeFalse()
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