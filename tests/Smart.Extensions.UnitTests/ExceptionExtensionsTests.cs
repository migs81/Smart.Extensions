using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(ExceptionExtensions))]
public class ExceptionExtensionsTests
{
    #region HasInnerException

    [Fact]
    public void HasInnerException_WhenInnerExceptionExists_ShouldReturnTrue()
    {
        // arrange
        var exception = new Exception("", new Exception());
        
        // act
        var result = exception.HasInnerException();
        
        // assert
        Assert.True(result);
    }

    [Fact]
    public void HasInnerException_WhenNoInnerExceptionExists_ShouldReturnFalse()
    {
        // arrange
        var exception = new Exception("");
        
        // act
        var result = exception.HasInnerException();
        
        // assert
        Assert.False(result);
    }
    
    [Fact]
    public void HasInnerException_WhenExceptionIsNull_ShouldThrow()
    {
        // arrange
        Exception? exception = null;
        
        // act
        var result = Record.Exception(() => exception!.HasInnerException());
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion

    #region GetBaseMessage

    [Fact]
    public void GetBaseMessage_WhenInnerExceptionExists_ShouldReturnInnermostMessage()
    {
        // arrange
        var exception = new Exception("abc", new Exception("xyz"));
        
        // act
        var result = exception.GetBaseMessage();
        
        // assert
        Assert.Equal("xyz", result);
    }

    [Fact]
    public void GetBaseMessage_WhenNoInnerExceptionExists_ShouldReturnOriginalMessage()
    {
        // arrange
        var exception = new Exception("abc");
        
        // act
        var result = exception.GetBaseMessage();
        
        // assert
        Assert.Equal("abc", result);
    }
    
    [Fact]
    public void GetBaseMessage_WhenExceptionIsNull_ShouldThrow()
    {
        // arrange
        Exception? exception = null;
        
        // act
        var result = Record.Exception(exception!.GetBaseMessage);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion
    
    #region GetFullMessage

    [Fact]
    public void GetFullMessage_WhenInnerExceptionExists_ShouldReturnAllMessages()
    {
        // arrange
        var exception = new Exception("abc", new Exception("xyz"));
        
        // act
        var result = exception.GetFullMessage();
        
        // assert
        Assert.Equal($"abc{Environment.NewLine}xyz", result);
    }

    [Fact]
    public void GetFullMessage_WhenNoInnerExceptionExists_ShouldReturnSingleMessage()
    {
        // arrange
        var exception = new Exception("abc");
        
        // act
        var result = exception.GetFullMessage();
        
        // assert
        Assert.Equal("abc", result);
    }
    
    [Fact]
    public void GetFullMessage_WhenExceptionIsNull_ShouldThrow()
    {
        // arrange
        Exception? exception = null;
        
        // act
        var result = Record.Exception(exception!.GetFullMessage);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion
    
    #region GetMessages

    [Fact]
    public void GetMessages_WhenInnerExceptionExists_ShouldReturnAllMessages()
    {
        // arrange
        var exception = new Exception("abc", new Exception("xyz"));
        
        // act
        var result = exception.GetMessages();
        
        // assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);
        Assert.Contains("abc", result);
        Assert.Contains("xyz", result);
    }

    [Fact]
    public void GetMessages_WhenNoInnerExceptionExists_ShouldReturnSingleMessage()
    {
        // arrange
        var exception = new Exception("abc");
        
        // act
        var result = exception.GetMessages();
        
        // assert
        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Contains("abc", result);
    }
    
    [Fact]
    public void GetMessages_WhenExceptionIsNull_ShouldThrow()
    {
        // arrange
        Exception? exception = null;
        
        // act
        var result = Record.Exception(exception!.GetMessages);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion
    
    #region Contains

    [Fact]
    public void Contains_WhenInnerExceptionMatchesType_ShouldReturnTrue()
    {
        // arrange
        var exception = new Exception("", new NullReferenceException());
        
        // act
        var result = exception.Contains<NullReferenceException>();
        
        // assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_WhenExceptionDoesNotMatchType_ShouldReturnFalse()
    {
        // arrange
        var exception = new Exception("");
        
        // act
        var result = exception.Contains<NullReferenceException>();
        
        // assert
        Assert.False(result);
    }
    
    [Fact]
    public void Contains_WhenExceptionIsNull_ShouldThrow()
    {
        // arrange
        Exception? exception = null;
        
        // act
        var result = Record.Exception(() => exception!.Contains<NullReferenceException>());
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion
}