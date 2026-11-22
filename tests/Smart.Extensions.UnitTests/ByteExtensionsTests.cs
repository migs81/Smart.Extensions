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
    
    #region GetSha1Hash
    
    [Theory]
    [InlineData("test", "A94A8FE5CCB19BA61C4C0873D391E987982FBBD3")]
    [InlineData("Hello world", "7B502C3A1F48C8609AE212CDFB639DEE39673F5E")]
    [InlineData("123abc", "4BE30D9814C6D4E9800E0D2EA9EC9FB00EFA887B")]
    public void GetSha1Hash_WhenBytesAreProvided_ShouldReturnHexString(string input, string expected)
    {
        // arrange
        var bytes = Encoding.UTF8.GetBytes(input);
        
        // act
        var actual = bytes.GetSha1Hash();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetSha1Hash_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;
        
        // act
        var result = Record.Exception(bytes.GetSha1Hash);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    #endregion
    
    #region GetSha256Hash
    
    [Theory]
    [InlineData("test", "9F86D081884C7D659A2FEAA0C55AD015A3BF4F1B2B0B822CD15D6C15B0F00A08")]
    [InlineData("Hello world", "64EC88CA00B268E5BA1A35678A1B5316D212F4F366B2477232534A8AECA37F3C")]
    [InlineData("123abc", "DD130A849D7B29E5541B05D2F7F86A4ACD4F1EC598C1C9438783F56BC4F0FF80")]
    public void GetSha256Hash_WhenBytesAreProvided_ShouldReturnHexString(string input, string expected)
    {
        // arrange
        var bytes = Encoding.UTF8.GetBytes(input);
        
        // act
        var actual = bytes.GetSha256Hash();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetSha256Hash_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;
        
        // act
        var result = Record.Exception(bytes.GetSha256Hash);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    #endregion
    
    #region GetSha384Hash
    
    [Theory]
    [InlineData("test", "768412320F7B0AA5812FCE428DC4706B3CAE50E02A64CAA16A782249BFE8EFC4B7EF1CCB126255D196047DFEDF17A0A9")]
    [InlineData("Hello world", "9203B0C4439FD1E6AE5878866337B7C532ACD6D9260150C80318E8AB8C27CE330189F8DF94FB890DF1D298FF360627E1")]
    [InlineData("123abc", "40889BD7AEE5BE35F9D713C4F51FF00FE2099FD901D094284D6EDC9AA39EC096CEBE9547D3CBAF1F35101A6489F033C3")]
    public void GetSha384Hash_WhenBytesAreProvided_ShouldReturnHexString(string input, string expected)
    {
        // arrange
        var bytes = Encoding.UTF8.GetBytes(input);
        
        // act
        var actual = bytes.GetSha384Hash();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetSha384Hash_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;
        
        // act
        var result = Record.Exception(bytes.GetSha384Hash);
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    #endregion
    
    #region GetSha512Hash
    
    [Theory]
    [InlineData("test", "EE26B0DD4AF7E749AA1A8EE3C10AE9923F618980772E473F8819A5D4940E0DB27AC185F8A0E1D5F84F88BC887FD67B143732C304CC5FA9AD8E6F57F50028A8FF")]
    [InlineData("Hello world", "B7F783BAED8297F0DB917462184FF4F08E69C2D5E5F79A942600F9725F58CE1F29C18139BF80B06C0FFF2BDD34738452ECF40C488C22A7E3D80CDF6F9C1C0D47")]
    [InlineData("123abc", "7B6AD79B346FB6951275343948E13C1B4EBCA82A5452A6C5D15684377F096CA927506A23A847E6E046061399631B16FC2820C8B0E02D0EA87AA5A203A77C2A7E")]
    public void GetSha512Hash_WhenBytesAreProvided_ShouldReturnHexString(string input, string expected)
    {
        // arrange
        var bytes = Encoding.UTF8.GetBytes(input);
        
        // act
        var actual = bytes.GetSha512Hash();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetSha512Hash_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;
        
        // act
        var result = Record.Exception(bytes.GetSha512Hash);
        
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
    
    #region ToAsciiString

    [Fact]
    public void ToAsciiString_WhenBytesAreProvided_ShouldReturnDecodedString()
    {
        // arrange
        const string expected = "test";
        var bytes = Encoding.ASCII.GetBytes(expected);

        // act
        var result = bytes.ToAsciiString();

        // assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void ToAsciiString_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;

        // act
        var result = Record.Exception(bytes.ToAsciiString);

        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion

    #region ToBase64String

    [Fact]
    public void ToBase64String_WhenBytesAreProvided_ShouldReturnBase64String()
    {
        // arrange
        const string expected = "dGVzdA==";
        var bytes = Encoding.UTF8.GetBytes("test");

        // act
        var result = bytes.ToBase64String();

        // assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void ToBase64String_WhenBytesAreNull_ShouldThrow()
    {
        // arrange
        byte[] bytes = null!;

        // act
        var result = Record.Exception(bytes.ToAsciiString);

        // assert
        Assert.IsType<ArgumentNullException>(result);
    }

    #endregion
}