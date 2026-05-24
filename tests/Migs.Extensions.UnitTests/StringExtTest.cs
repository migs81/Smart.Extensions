using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace Migs.Extensions.UnitTests;

[TestSubject(typeof(StringExt))]
public class StringExtTest
{
    #region IsGuid

    [Fact]
    public void IsGuid_ValidInput_ShouldReturnTrue()
    {
        // arrange
        var guid = Guid.Empty.ToString();
        
        // act
        var result = guid.IsGuid();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("abc")]
    public void IsGuid_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result = input.IsGuid();
        
        // assert
        Assert.False(result);
    }
    
    #endregion
    
    #region IsMailAddress

    [Fact]
    public void IsMailAddress_ValidInput_ShouldReturnTrue()
    {
        // arrange
        var mail = "abc@xyz.com";
        
        // act
        var result = mail.IsMailAddress();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("abc")]
    public void IsMailAddress_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result = input.IsMailAddress();
        
        // assert
        Assert.False(result);
    }
    
    #endregion
    
    #region IsDate

    [Theory]
    [InlineData("1999-01-01")]
    [InlineData("1999-12-15 05:00")]
    [InlineData("05/05/2000")]
    [InlineData("2000/05/05")]
    [InlineData("05/05/2000 05:05")]
    [InlineData("2000/05/05 05:05")]
    [InlineData("01.12.2000")]
    [InlineData("01.12.2000 12:35")]
    public void IsDate_ValidInput_ShouldReturnTrue(string? input)
    {
        // act
        var result = input.IsDate();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("abc")]
    [InlineData("1010101010")]
    public void IsDate_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result = input.IsDate();
        
        // assert
        Assert.False(result);
    }
    
    #endregion
    
    #region IsUri

    [Theory]
    [InlineData("http://www.abc.com")]
    [InlineData("https://abc.com")]
    [InlineData("ftp://abc.com")]
    public void IsUri_ValidInput_ShouldReturnTrue(string? input)
    {
        // act
        var result = input.IsUri();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("")]
    [InlineData("abc")]
    public void IsUri_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result = input.IsUri();
        
        // assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsUri_NullValue_ShouldThrowException()
    {
        // arrange
        string? source = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(() =>  source.IsUri());
    }
    
    #endregion
    
    #region Truncate

    [Fact]
    public void Truncate_ValidInput_ShouldEqualNewString()
    {
        // arrange
        const string input = "abcdefghijklmnopqrstuvwxyz";
        
        // act
        var result = input.Truncate(3, "...");
        
        // assert
        Assert.Equal("abc...", result);
    }
    
    [Theory]
    [InlineData("abc", -1, "...")]
    [InlineData("abc", 10, "...")]
    public void Truncate_WrongInput_ShouldReturnNewString(string? input, int maxLength, string suffix)
    {
        // act
        var result = input.Truncate(maxLength);
        
        // assert
        Assert.Equal($"{input}{suffix}", result);
    }
    
    [Fact]
    public void Truncate_EmptyInput_ShouldReturnSource()
    {
        // arrange
        const string input = "";
        
        // act
        var result = input.Truncate(3);
        
        // assert
        Assert.Equal(input, result);
    }
    
    [Fact]
    public void Truncate_NullSource_ShouldThrowException()
    {
        // arrange
        string? source = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(() =>  source.Truncate(3, ".."));
    }
    
    #endregion
    
    #region IsDigit

    [Theory]
    [InlineData("abc1abc", 3)]
    [InlineData("123", 1)]
    [InlineData("aaaaaaaaaa1", 10)]
    public void IsDigit_ValidInput_ShouldReturnTrue(string? input, int index)
    {
        // act
        var result = input.IsDigit(index);
        
        // assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsDigit_WrongInput_ShouldReturnFalse()
    {
        // arrange
        const string input = "abc";
        
        // act
        var result = input.IsDigit(1);
        
        // assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsDigit_NullValue_ShouldThrowException()
    {
        // arrange
        string? source = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(() =>  source.IsDigit(1));
    }
    
    #endregion
    
    #region IsLetter

    [Theory]
    [InlineData("123a", 3)]
    [InlineData("0a123", 1)]
    [InlineData("0123456789a", 10)]
    public void IsLetter_ValidInput_ShouldReturnTrue(string? input, int index)
    {
        // act
        var result = input.IsLetter(index);
        
        // assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsLetter_WrongInput_ShouldReturnFalse()
    {
        // arrange
        const string input = "123";
        
        // act
        var result = input.IsLetter(1);
        
        // assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsLetter_NullValue_ShouldThrowException()
    {
        // arrange
        string? source = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(() =>  source.IsLetter(1));
    }
    
    #endregion
    
    #region IsLetterOrDigit

    [Theory]
    [InlineData("1", 0)]
    [InlineData("a", 0)]
    [InlineData("abc123", 4)]
    public void IsLetterOrDigit_ValidInput_ShouldReturnTrue(string? input, int index)
    {
        // act
        var result = input.IsLetterOrDigit(index);
        
        // assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsLetterOrDigit_WrongInput_ShouldReturnFalse()
    {
        // arrange
        const string input = "abc.123";
        
        // act
        var result = input.IsLetterOrDigit(3);
        
        // assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsLetterOrDigit_NullValue_ShouldThrowException()
    {
        // arrange
        string? source = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(() =>  source.IsLetterOrDigit(1));
    }
    
    #endregion
    
    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    public void IsHighSurrogate_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsHighSurrogate(0));
    }
    
    [Theory]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsHighSurrogate_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsHighSurrogate(0));
    }
    
    [Theory]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsLowSurrogate_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsLowSurrogate(0));
    }
    
    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    public void IsLowSurrogate_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsLowSurrogate(0));
    }
    
    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsSurrogate_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsSurrogate(0));
    }
    
    [Theory]
    [InlineData('.')]
    [InlineData(',')]
    [InlineData('!')]
    [InlineData('?')]
    [InlineData(';')]
    [InlineData(':')]
    [InlineData('"')]
    [InlineData('\\')]
    [InlineData('(')]
    [InlineData(')')]
    [InlineData('[')]
    [InlineData(']')]
    [InlineData('{')]
    [InlineData('}')]
    [InlineData('-')]
    [InlineData('/')]
    public void IsPunctuation_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsPunctuation(0));
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('A')]
    [InlineData('0')]
    public void IsPunctuation_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsPunctuation(0));
    }
    
    [Theory]
    [InlineData(' ')]      // Space (U+0020)
    [InlineData('\u00A0')] // No-Break Space (NBSP)
    [InlineData('\u1680')] // Ogham Space Mark
    [InlineData('\u2000')] // En Quad
    [InlineData('\u2001')] // Em Quad
    [InlineData('\u2002')] // En Space
    [InlineData('\u2003')] // Em Space
    [InlineData('\u2004')] // Three-Per-Em Space
    [InlineData('\u2005')] // Four-Per-Em Space
    [InlineData('\u2006')] // Six-Per-Em Space
    [InlineData('\u2007')] // Figure Space
    [InlineData('\u2008')] // Punctuation Space
    [InlineData('\u2009')] // Thin Space
    [InlineData('\u200A')] // Hair Space
    [InlineData('\u2028')] // Line Separator
    [InlineData('\u2029')] // Paragraph Separator
    [InlineData('\u202F')] // Narrow No-Break Space
    [InlineData('\u205F')] // Medium Mathematical Space
    [InlineData('\u3000')] // Ideographic Space (CJK)
    public void IsSeparator_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsSeparator(0));
    }
    
    [Theory]
    [InlineData('\n')]
    [InlineData('\r')]
    [InlineData('\t')]
    [InlineData(',')]
    [InlineData('.')]
    [InlineData('A')]
    [InlineData('1')]
    [InlineData(char.MinValue)]
    [InlineData(char.MaxValue)]
    public void IsSeparator_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsSeparator(0));
    }
    
    [Theory]
    [InlineData('A')]
    [InlineData('Z')]
    public void IsUpper_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsUpper(0));
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('z')]
    public void IsUpper_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsUpper(0));
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('z')]
    public void IsLower_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsLower(0));
    }
    
    [Theory]
    [InlineData('A')]
    [InlineData('Z')]
    public void IsLower_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsLower(0));
    }
    
    [Theory]
    [InlineData(' ')] // Space (U+0020)
    [InlineData('\t')] // Tab (U+0009)
    [InlineData('\n')] // Line Feed (U+000A)
    [InlineData('\r')] // Carriage Return (U+000D)
    [InlineData('\f')] // Form Feed (U+000C)
    [InlineData('\v')] // Vertical Tab (U+000B)
    [InlineData('\u00A0')] // No-Break Space (NBSP)
    [InlineData('\u202F')] // Narrow No-Break Space
    [InlineData('\u1680')] // Ogham Space Mark
    [InlineData('\u2000')] // En Quad
    [InlineData('\u2001')] // Em Quad
    [InlineData('\u2002')] // En Space
    [InlineData('\u2003')] // Em Space
    [InlineData('\u2004')] // Three-Per-Em Space
    [InlineData('\u2005')] // Four-Per-Em Space
    [InlineData('\u2006')] // Six-Per-Em Space
    [InlineData('\u2007')] // Figure Space
    [InlineData('\u2008')] // Punctuation Space
    [InlineData('\u2009')] // Thin Space
    [InlineData('\u200A')] // Hair Space
    [InlineData('\u2028')] // Line Separator
    [InlineData('\u2029')] // Paragraph Separator
    [InlineData('\u205F')] // Medium Mathematical Space
    [InlineData('\u3000')] // Ideographic Space (CJK)
    public void IsWhiteSpace_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsWhiteSpace(0));
    }
    
    [Theory]
    [InlineData('A')] // Letter
    [InlineData('1')] // Digit
    [InlineData(',')] // Comma (punctuation)
    [InlineData('.')] // Dot (punctuation)
    [InlineData('«')] // Quotation mark (punctuation)
    [InlineData(char.MinValue)] // Null character
    [InlineData(char.MaxValue)] // Invalid character (U+FFFF)
    [InlineData('\u00AD')] // Soft Hyphen
    [InlineData('\u2013')] // En Dash
    public void IsWhiteSpace_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsWhiteSpace(0));
    }
    
    [Theory]
    [InlineData('+')] // Plus (U+002B)
    [InlineData('=')] // Equals (U+003D)
    [InlineData('×')] // Multiplication (U+00D7)
    [InlineData('÷')] // Division (U+00F7)
    [InlineData('±')] // Plus-minus (U+00B1)
    [InlineData('∑')] // Summation (U+2211)
    [InlineData('√')] // Square root (U+221A)
    [InlineData('∞')] // Infinity (U+221E)
    [InlineData('∫')] // Integral (U+222B)
    [InlineData('≈')] // Almost equal (U+2248)
    [InlineData('≤')] // Less than or equal (U+2264)
    [InlineData('≥')] // Greater than or equal (U+2265)
    [InlineData('$')] // Dollar (U+0024)
    [InlineData('€')] // Euro (U+20AC)
    [InlineData('¥')] // Yen (U+00A5)
    [InlineData('£')] // Pound (U+00A3)
    [InlineData('¢')] // Cent (U+00A2)
    [InlineData('₿')] // Bitcoin (U+20BF)
    [InlineData('^')] // Circumflex (U+005E)
    [InlineData('~')] // Tilde (U+007E)
    [InlineData('`')] // Grave accent (U+0060)
    [InlineData('˜')] // Small tilde (U+02DC)
    [InlineData('©')] // Copyright (U+00A9)
    [InlineData('®')] // Registered (U+00AE)
    [InlineData('™')] // Trademark (U+2122)
    public void IsSymbol_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsSymbol(0));
    }
    
    [Theory]
    [InlineData('A')] // Letter
    [InlineData('1')] // Digit
    [InlineData(' ')] // Space
    [InlineData('\n')] // Line feed
    [InlineData(',')] // Comma (punctuation)
    [InlineData('.')] // Dot (punctuation)
    [InlineData('«')] // Quotation mark (punctuation)
    [InlineData(char.MinValue)] // Null character
    [InlineData(char.MaxValue)] // Invalid character (U+FFFF)
    public void IsSymbol_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsSymbol(0));
    }
    
    [Theory]
    [InlineData('\u0000')] // Null (NUL)
    [InlineData('\u0001')] // Start of Heading (SOH)
    [InlineData('\u0002')] // Start of Text (STX)
    [InlineData('\u0003')] // End of Text (ETX)
    [InlineData('\u0004')] // End of Transmission (EOT)
    [InlineData('\u0005')] // Enquiry (ENQ)
    [InlineData('\u0006')] // Acknowledge (ACK)
    [InlineData('\u0007')] // Bell (BEL, alert)
    [InlineData('\u0008')] // Backspace (BS)
    public void IsControl_ValidInput_ShouldBeTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.True(text.IsControl(0));
    }
    
    [Theory]
    [InlineData(' ')] // Space (not a control character)
    [InlineData('A')] // Letter
    [InlineData('1')] // Digit
    [InlineData(',')] // Punctuation
    [InlineData('.')] // Punctuation
    public void IsControl_WrongInput_ShouldBeFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // assert
        Assert.False(text.IsControl(0));
    }
}