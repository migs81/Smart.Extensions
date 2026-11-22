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
    public void ToHexString_WhenBytesAreProvided_ShouldReturnHexString(string input, string expected)
    {
        // arrange
        var bytes = Encoding.UTF8.GetBytes(input);
        
        // act
        var actual = bytes.ToHexString();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void ToHexString_BytesAreNull_ShouldThrow()
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
    public void GetMd5Hash_WhenBytesAreProvided_ShouldReturnHexString(string input, string expected)
    {
        // arrange
        var bytes = Encoding.UTF8.GetBytes(input);
        
        // act
        var actual = bytes.GetMd5Hash();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMd5Hash_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;
        
        // act
        var result = Record.Exception(bytes.GetMd5Hash);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    #endregion
    
    #region ToStream
    
    [Fact]
    public void ToStream_WhenBytesAreProvided_ShouldReturnMemoryStream()
    {
        // arrange
        var bytes = new byte[] { 1, 2, 3 };

        // act
        var stream = bytes.ToStream();

        // assert
        Assert.IsType<MemoryStream>(stream);
    }

    [Fact]
    public void ToStream_WhenBytesAreProvided_ShouldContainAllBytes()
    {
        // arrange
        var bytes = new byte[] { 1, 2, 3 };

        // act
        using var stream = bytes.ToStream();
        
        // assert
        Assert.Equal(bytes, ((MemoryStream)stream).ToArray());
    }

    [Fact]
    public void ToStream_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;

        // act
        var result = Record.Exception(bytes.ToStream);

        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    #endregion

    #region ToUtf8String

    [Fact]
    public void ToUtf8String_WhenBytesAreProvided_ShouldReturnDecodedString()
    {
        // arrange
        const string expected = "test";
        var bytes = Encoding.UTF8.GetBytes(expected);

        // act
        var result = bytes.ToUtf8String();

        // assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void ToUtf8String_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;

        // act
        var result = Record.Exception(bytes.ToUtf8String);

        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion
    
    #region ToEncodedString

    [Theory]
    [InlineData("test", "ASCII")]
    [InlineData("test", "UTF-8")]
    [InlineData("test", "Unicode")]
    [InlineData("test", "UTF-32")]
    public void ToEncodedString_WhenBytesAreProvided_ShouldReturnDecodedString(string expected, string encodingName)
    {
        // arrange
        var encoding = Encoding.GetEncoding(encodingName);
        var bytes = encoding.GetBytes(expected);

        // act
        var result = bytes.ToEncodedString(encoding);

        // assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void ToEncodedString_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;

        // act
        var result = Record.Exception(() => bytes.ToEncodedString(Encoding.UTF8));

        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion
}