using System.Text;
using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(ByteExtensions))]
public class ByteExtensionsTests
{
    #region ToHexString

    [Theory]
    [InlineData("test", "74657374")]
    [InlineData("Hello world", "48656C6C6F20776F726C64")]
    [InlineData("123abc", "313233616263")]
    public void ToHexString_WhenInputIsNotNull_ShouldReturnHexString(string input, string expected)
    {
        // arrange
        var bytes = Encoding.UTF8.GetBytes(input);
        
        // act
        var actual = bytes.ToHexString();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void ToHexString_WhenInputIsNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;
        
        // act
        var result = Record.Exception(bytes.ToHexString);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    #endregion

    #region GetMd5Hash
    
    [Theory]
    [InlineData("test", "098F6BCD4621D373CADE4E832627B4F6")]
    [InlineData("Hello world", "3E25960A79DBC69B674CD4EC67A72C62")]
    [InlineData("123abc", "A906449D5769FA7361D7ECC6AA3F6D28")]
    public void GetMd5Hash_WhenInputIsNotNull_ShouldReturnHexString(string input, string expected)
    {
        // arrange
        var bytes = Encoding.UTF8.GetBytes(input);
        
        // act
        var actual = bytes.GetMd5Hash();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMd5Hash_WhenInputIsNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;
        
        // act
        var result = Record.Exception(bytes.GetMd5Hash);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    #endregion
}