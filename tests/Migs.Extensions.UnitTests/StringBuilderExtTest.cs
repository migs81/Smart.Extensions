using System.Text;
using JetBrains.Annotations;
using Migs.Extensions.StringBuilders;

namespace Migs.Extensions.UnitTests;

[TestSubject(typeof(StringBuilderExt))]
public class StringBuilderExtTest
{
    #region AppendIf

    [Fact]
    public void AppendIf_ValidCondition_ShouldEqualNewString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendIf(true, "cd");
        
        // assert
        Assert.Equal("abcd", sb.ToString());
    }
    
    [Fact]
    public void AppendIf_WrongCondition_ShouldEqualOriginalString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendIf(false, "cd");
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }
    
    [Fact]
    public void AppendIf_NullValue_ShouldEqualOriginalString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendIf(true, null);
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }

    [Fact]
    public void AppendIf_NullSource_ShouldThrowException()
    {
        // arrange
        StringBuilder? sb = null;
        
        // assert
        Assert.Throws<NullReferenceException>(() => sb.AppendIf(true,"cd"));        
    }

    #endregion

    #region AppendLineIf

    [Fact]
    public void AppendLineIf_ValidCondition_ShouldEqualNewString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendLineIf(true, "cd");
        
        // assert
        Assert.Equal($"abcd{Environment.NewLine}", sb.ToString());
    }
    
    [Fact]
    public void AppendLineIf_WrongCondition_ShouldEqualOriginalString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendLineIf(false, "cd");
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }
    
    [Fact]
    public void AppendLineIf_NullInput_ShouldEqualOriginalString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendLineIf(true, null);
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }
    
    [Fact]
    public void AppendLineIf_NullSource_ShouldThrowException()
    {
        // arrange
        StringBuilder? sb = null;
        
        // assert
        Assert.Throws<NullReferenceException>(() => sb.AppendLineIf(true,"cd"));        
    }

    #endregion

    #region AppendIfNotNullOrEmpty

    [Fact]
    public void AppendIfNotNullOrEmpty_ValidInput_ShouldEqualNewString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendIfNotNullOrEmpty("cd");
        
        // assert
        Assert.Equal("abcd", sb.ToString());
    }
    
    [Fact]
    public void AppendIfNotNullOrEmpty_NullInput_ShouldEqualOriginalString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendIfNotNullOrEmpty(null);
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }
    
    [Fact]
    public void AppendIfNotNullOrEmpty_EmptyInput_ShouldEqualOriginalString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendIfNotNullOrEmpty("");
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }
    
    #endregion
    
    #region AppendLineIfNotNullOrEmpty

    [Fact]
    public void AppendLineIfNotNullOrEmpty_ValidInput_ShouldEqualNewString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendLineIfNotNullOrEmpty("cd");
        
        // assert
        Assert.Equal($"abcd{Environment.NewLine}", sb.ToString());
    }
    
    [Fact]
    public void AppendLineIfNotNullOrEmpty_NullInput_ShouldEqualOriginalString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendLineIfNotNullOrEmpty(null);
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }
    
    [Fact]
    public void AppendLineIfNotNullOrEmpty_EmptyInput_ShouldEqualOriginalString()
    {
        // arrange
        var sb = new StringBuilder("ab");
        
        // act
        sb.AppendLineIfNotNullOrEmpty("");
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }
    
    #endregion

    #region AppendLines

    [Fact]
    public void AppendLines_ValidInput_ShouldEqualNewString()
    {
        // arrange
        var sb = new StringBuilder();
        var list = new List<string>() { "ab", "cd" };
        
        // act
        sb.AppendLines(list);
        
        // assert
        Assert.Equal($"ab{Environment.NewLine}cd{Environment.NewLine}", sb.ToString());
    }
    
    [Fact]
    public void AppendLines_NullSource_ShouldThrowException()
    {
        // arrange
        StringBuilder? sb = null;
        var list = new List<string> { "" };
        
        // assert
        Assert.Throws<ArgumentNullException>(() => sb.AppendLines(list));
    }

    [Fact]
    public void AppendLines_NullValue_ShouldEqualOriginalString()
    {
        // arrange
        var sb =  new StringBuilder("ab");

        // act
        sb.AppendLines(null);
        
        // assert
        Assert.Equal("ab", sb.ToString());
    }
    
    #endregion
}