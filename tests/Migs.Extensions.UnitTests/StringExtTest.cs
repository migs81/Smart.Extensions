using System.Text;
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
    [InlineData(null)]
    [InlineData("")]
    [InlineData("abc")]
    [InlineData("abc.com")]
    public void IsUri_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result = input.IsUri();
        
        // assert
        Assert.False(result);
    }
    
    #endregion
    
    #region Truncate

    [Fact]
    public void Truncate_ValidInput_ShouldReturnNewString()
    {
        // arrange
        const string input = "abcdefghijklmnopqrstuvwxyz";
        const string expected = "abc...";
        
        // act
        var result =  input.Truncate(3, "...");
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("abc", -1, "...")]
    [InlineData("abc", 10, "...")]
    public void Truncate_WrongInput_ShouldReturnNewString(string? input, int maxLength, string suffix)
    {
        // arrange
        var expected = $"{input}{suffix}";
        
        // act
        var result =  input.Truncate(maxLength);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Truncate_EmptyInput_ShouldReturnEmptyString()
    {
        // arrange
        const string input = "";
        const string expected = "";
        
        // act
        var result =  input.Truncate(3);
        
        // assert
        Assert.Equal(expected, result);
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
    
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("abc", 0)]
    public void IsDigit_WrongInput_ShouldReturnFalse(string? input, int index)
    {
        // act
        var result = input.IsDigit(index);
        
        // assert
        Assert.False(result);
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
    
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("0", 0)]
    public void IsLetter_WrongInput_ShouldReturnFalse(string? input, int index)
    {
        // act
        var result = input.IsLetter(index);
        
        // assert
        Assert.False(result);
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
    
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("-", 0)]
    public void IsLetterOrDigit_WrongInput_ShouldReturnFalse(string? input, int index)
    {
        // act
        var result = input.IsLetterOrDigit(index);
        
        // assert
        Assert.False(result);
    }
    
    #endregion

    #region IsHighSurrogate

    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    public void IsHighSurrogate_ValidInput_ShouldReturnTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsHighSurrogate(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void IsHighSurrogate_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result =  input.IsHighSurrogate(0);
            
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsHighSurrogate_WrongCharacter_ShouldReturnFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsHighSurrogate(0);
        
        // assert
        Assert.False(result);
    }
    
    #endregion
    
    #region IsLowSurrogate
    
    [Theory]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsLowSurrogate_ValidInput_ShouldReturnTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsLowSurrogate(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("a")]
    public void IsLowSurrogate_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result = input.IsLowSurrogate(0);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    public void IsLowSurrogate_WrongCharacter_ShouldReturnFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsLowSurrogate(0);
        
        // assert
        Assert.False(result);
    }
    
    #endregion

    #region IsSurrogate

    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsSurrogate_ValidInput_ShouldReturnTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsSurrogate(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("a")]
    public void IsSurrogate_WrongInput_ShouldReturnTrue(string? input)
    {
        // assert
        Assert.False(input.IsSurrogate(0));
    }

    #endregion

    #region IsPunctuation

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
    public void IsPunctuation_ValidInput_ShouldReturnTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsPunctuation(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("a")]
    public void IsPunctuation_WrongInput_ShouldReturnFalse(string? input)
    {
        // assert
        Assert.False(input.IsPunctuation(0));
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('A')]
    [InlineData('0')]
    public void IsPunctuation_WrongCharacter_ShouldReturnFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsPunctuation(0);
        
        // assert
        Assert.False(result);
    }

    #endregion

    #region IsSeparator

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
    public void IsSeparator_ValidInput_ShouldReturnTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsSeparator(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("a")]
    public void IsSeparator_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result =  input.IsSeparator(0);
        
        // assert
        Assert.False(result);
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
    public void IsSeparator_WrongCharacter_ShouldReturnFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result =  text.IsSeparator(0);
        
        // assert
        Assert.False(result);
    }

    #endregion

    #region IsUpper

    [Theory]
    [InlineData("A", 0)]
    [InlineData("aBc", 1)]
    public void IsUpper_ValidCharacterAtIndex_ShouldReturnTrue(string input, int index)
    {
        // act
        var result = input.IsUpper(index);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("ABC")]
    [InlineData("ABC!")]
    [InlineData("ABC123!")]
    public void IsUpper_ValidInput_ShouldReturnTrue(string? input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result = text.IsUpper(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("a", 0)]
    [InlineData("AbC", 1)]
    public void IsUpper_WrongCharacterAtIndex_ShouldReturnFalse(string? input, int index)
    {
        // act
        var result = input.IsUpper(index);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("aBC")]
    public void IsUpper_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result = input.IsUpper();
        
        // assert
        Assert.False(result);
    }

    #endregion

    #region IsLower

    [Theory]
    [InlineData("a", 0)]
    [InlineData("AbC", 1)]
    public void IsLower_ValidCharacterAtIndex_ShouldReturnTrue(string input, int index)
    {
        // act
        var result = input.IsLower(index);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("a")]
    [InlineData("abc")]
    [InlineData("abc!")]
    [InlineData("abc123!")]
    public void IsLower_ValidInput_ShouldReturnTrue(string input)
    {
        // act
        var result = input.IsLower();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("A", 0)]
    [InlineData("aBc", 1)]
    public void IsLower_WrongCharacterAtIndex_ShouldReturnFalse(string? input, int index)
    {
        // act
        var result = input.IsLower(index);
        
        // assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("A")]
    [InlineData("AbC")]
    public void IsLower_WrongInput_ShouldReturnFalse(string? input)
    {
        // act
        var result = input.IsLower();
        
        // assert
        Assert.False(result);
    }
    
    #endregion

    #region IsWhiteSpace

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
    public void IsWhiteSpace_ValidCharacter_ShouldReturnTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result = text.IsWhiteSpace(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("a", 0)]
    public void IsWhiteSpace_WrongInput_ShouldReturnFalse(string? input, int index)
    {
        // act
        var result = input.IsWhiteSpace(index);
        
        // assert
        Assert.False(result);
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
    public void IsWhiteSpace_WrongCharacter_ShouldReturnFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result = text.IsWhiteSpace(0);
        
        // assert
        Assert.False(result);
    }
    
    #endregion

    #region IsSymbol

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
    public void IsSymbol_ValidCharacter_ShouldReturnTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result = text.IsSymbol(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData("+", 0)] // Plus (U+002B)
    [InlineData("a=", 1)] // Equals (U+003D)
    public void IsSymbol_ValidInput_ShouldReturnTrue(string input, int index)
    {
        // act
        var result =  input.IsSymbol(index);
        
        // assert
        Assert.True(result);
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
    public void IsSymbol_WrongCharacter_ShouldReturnFalse(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result = text.IsSymbol(0);
        
        // assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(null, 0)] 
    [InlineData("", 0)] 
    [InlineData("abc", 1)] 
    public void IsSymbol_WrongInput_ShouldReturnFalse(string? input, int index)
    {
        // act
        var result = input.IsSymbol(index);
        
        // assert
        Assert.False(result);
    }
    
    #endregion

    #region IsControl

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
    public void IsControl_ValidCharacter_ShouldReturnTrue(char input)
    {
        // arrange
        var text = $"{input}";
        
        // act
        var result = text.IsControl(0);
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null, 0)] 
    [InlineData("", 0)] 
    [InlineData("abc", 1)] 
    public void IsControl_WrongInput_ShouldReturnFalse(string? input, int index)
    {
        // arrange
        var result = input.IsControl(index);
        
        // assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(' ')] // Space (not a control character)
    [InlineData('A')] // Letter
    [InlineData('1')] // Digit
    [InlineData(',')] // Punctuation
    [InlineData('.')] // Punctuation
    public void IsControl_WrongCharacter_ShouldReturnFalse(char input)
    {
        // arrange
        var result = $"{input}".IsControl(0);
        
        // assert
        Assert.False(result);
    }
    
    #endregion

    #region ToByteArray

    [Theory]
    [InlineData("")]
    [InlineData("abc")]
    [InlineData("abc 123 ABC 123")]
    public void ToByteArray_ValidInput_ShouldBeEqual(string value)
    {
        // arrange
        var expected= Encoding.UTF8.GetBytes(value);
        
        // act
        var result= value.ToByteArray(new UTF8Encoding());
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(null, null)]
    [InlineData("abc", null)]
    public void ToByteArray_NullInput_ShouldThrowException(string? input, Encoding? encoding)
    {
        // assert
        Assert.Throws<ArgumentNullException>(() => input.ToByteArray(encoding));
    }
    
    #endregion

    #region IsNumeric

    [Theory]
    [InlineData("123")]
    [InlineData("-200")]
    [InlineData("3453452351")]
    public void IsNumeric_ValidInput_ShouldReturnTrue(string value)
    {
        // arrange
        var result = value.IsNumeric();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("12a")]
    [InlineData("abc!")]
    public void IsNumeric_WrongInput_ShouldReturnFalse(string? value)
    {
        // arrange
        var result = value.IsNumeric();
        
        // assert
        Assert.False(result);
    }
    
    #endregion

    #region ToPascalCase

    [Theory]
    [InlineData("", "")]
    [InlineData("abc", "Abc")]
    [InlineData("aBC", "Abc")]
    [InlineData("ab123", "Ab123")]
    [InlineData("aBc aBC", "AbcAbc")]
    [InlineData("to camel case", "ToCamelCase")]
    [InlineData("to_camel-case!", "ToCamelCase")]
    
    public void ToPascalCase_ValidInput_ShouldReturnNewString(string input, string expected)
    {
        // arrange
        var result =  input.ToPascalCase();
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void ToPascalCase_NullInput_ShouldThrowException()
    {
        // arrange
        string? value = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(value.ToPascalCase);
    }
    
    #endregion
    
    #region ToCamelCase

    [Theory]
    [InlineData("", "")]
    [InlineData("abc", "abc")]
    [InlineData("aBC", "abc")]
    [InlineData("ab123", "ab123")]
    [InlineData("aBc aBC", "abcAbc")]
    [InlineData("to camel case", "toCamelCase")]
    [InlineData("to_camel-case!", "toCamelCase")]
    
    public void ToCamelCase_ValidInput_ShouldReturnNewString(string input, string expected)
    {
        // arrange
        var result =  input.ToCamelCase();
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void ToCamelCase_NullInput_ShouldThrowException()
    {
        // arrange
        string? value = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(value.ToCamelCase);
    }
    
    #endregion
    
    #region ToAlphaNumeric
    
    [Theory]
    [InlineData("", "")]
    [InlineData("a b c", "abc")]
    [InlineData("a-b_c^1!2?#!3", "abc123")]
    
    public void ToAlphaNumeric_ValidInput_ShouldReturnNewString(string input, string expected)
    {
        // arrange
        var result =  input.ToAlphaNumeric();
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void ToAlphaNumeric_NullInput_ShouldThrowException()
    {
        // arrange
        string? value = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(value.ToAlphaNumeric);
    }
    
    #endregion

    #region IsAlphaNumeric

    [Theory]
    [InlineData("abc123")]
    [InlineData("abc123ABC123")]
    
    public void IsAlphaNumeric_ValidInput_ShouldReturnTrue(string input)
    {
        // arrange
        var result = input.IsAlphaNumeric();
        
        // assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("abc_123!")]
    public void IsAlphaNumeric_WrongInput_ShouldReturnFalse(string? input)
    {
        // arrange
        var result = input.IsAlphaNumeric();
        
        // assert
        Assert.False(result);
    }

    #endregion
}