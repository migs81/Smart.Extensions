using System.Globalization;
using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(CharExtensions))]
public class CharExtensionsTests
{
    [Theory]
    [InlineData('a', 'A')]
    [InlineData('d', 'D')]
    [InlineData('m', 'M')]
    [InlineData('t', 'T')]
    [InlineData('z', 'Z')]
    [InlineData('1', '1')]
    [InlineData(':', ':')]
    public void ToUpper_ValidInput_ShouldReturnUppercase(char input, char expected)
    {
        // act
        var actual = input.ToUpper();
        
        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData('a', "en-US", 'A')]
    [InlineData('z', "en-US", 'Z')]
    [InlineData('i', "tr-TR", 'İ')]
    [InlineData('ı', "tr-TR", 'I')]
    [InlineData('ß', "de-DE", 'ß')]
    [InlineData('ς', "el-GR", 'Σ')]
    [InlineData('é', "fr-FR", 'É')]
    [InlineData('ñ', "es-ES", 'Ñ')]
    public void ToUpper_ValidInputWithCultureInfo_ShouldReturnUppercase(char input, string culture, char expected)
    {
        // arrange
        var cultureInfo = CultureInfo.GetCultureInfo(culture);
        
        // act
        var actual = input.ToUpper(cultureInfo);
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData('a', 'A')]
    [InlineData('z', 'Z')]
    [InlineData('i', 'I')]
    [InlineData('ı', 'ı')]
    [InlineData('ß', 'ß')]
    [InlineData('ς', 'Σ')]
    [InlineData('é', 'É')]
    [InlineData('ñ', 'Ñ')]
    [InlineData('α', 'Α')]
    [InlineData('?', '?')]
    [InlineData(';', ';')]
    public void ToUpperInvariant_ValidInput_ShouldReturnUppercase(char input, char expected)
    {
        // act
        var actual = input.ToUpperInvariant();
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData('A', 'a')]
    [InlineData('D', 'd')]
    [InlineData('M', 'm')]
    [InlineData('T', 't')]
    [InlineData('Z', 'z')]
    [InlineData('1', '1')]
    [InlineData(':', ':')]
    public void ToLower_ValidInput_ShouldReturnUppercase(char input, char expected)
    {
        // act
        var actual = input.ToLower();
        
        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData('A', "en-US", 'a')]
    [InlineData('Z', "en-US", 'z')]
    [InlineData('İ', "tr-TR", 'i')]
    [InlineData('I', "tr-TR", 'ı')]
    [InlineData('ß', "de-DE", 'ß')]
    [InlineData('Σ', "el-GR", 'σ')]
    [InlineData('É', "fr-FR", 'é')]
    [InlineData('Ñ', "es-ES", 'ñ')]
    public void ToLower_ValidInputWithCultureInfo_ShouldReturnUppercase(char input, string culture, char expected)
    {
        // arrange
        var cultureInfo = CultureInfo.GetCultureInfo(culture);
        
        // act
        var actual = input.ToLower(cultureInfo);
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData('A', 'a')]
    [InlineData('Z', 'z')]
    [InlineData('I', 'i')]
    [InlineData('ı', 'ı')]
    [InlineData('ß', 'ß')]
    [InlineData('Σ', 'σ')]
    [InlineData('É', 'é')]
    [InlineData('Ñ', 'ñ')]
    [InlineData('Α', 'α')]
    [InlineData('?', '?')]
    [InlineData(';', ';')]
    public void ToLowerInvariant_ValidInput_ShouldReturnUppercase(char input, char expected)
    {
        // act
        var actual = input.ToLowerInvariant();
        
        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData('0')]
    [InlineData('4')]
    [InlineData('9')]
    public void IsDigit_ValidInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.True(input.IsDigit());
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('z')]
    [InlineData('A')]
    [InlineData('Z')]
    [InlineData(':')]
    [InlineData('?')]
    public void IsDigit_WrongInput_ShouldBeFalse(char input)
    {
        // assert
        Assert.False(input.IsDigit());
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('z')]
    [InlineData('A')]
    [InlineData('Z')]
    public void IsLetter_ValidInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.True(input.IsLetter());
    }
    
    [Theory]
    [InlineData('0')]
    [InlineData('9')]
    [InlineData(':')]
    [InlineData('?')]
    public void IsLetter_WrongInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.False(input.IsLetter());
    }
    
    [Theory]
    [InlineData('0')]
    [InlineData('4')]
    [InlineData('9')]
    [InlineData('a')]
    [InlineData('z')]
    [InlineData('A')]
    [InlineData('Z')]
    public void IsLetterOrDigit_ValidInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.True(input.IsLetterOrDigit());
    }
    
    [Theory]
    [InlineData('-')]
    [InlineData('+')]
    [InlineData(':')]
    [InlineData('?')]
    public void IsLetterOrDigit_WrongInput_ShouldBeFalse(char input)
    {
        // assert
        Assert.False(input.IsLetterOrDigit());
    }
    
    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    public void IsHighSurrogate_ValidInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.True(input.IsHighSurrogate());
    }
    
    [Theory]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsHighSurrogate_WrongInput_ShouldBeFalse(char input)
    {
        // assert
        Assert.False(input.IsHighSurrogate());
    }
    
    [Theory]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsLowSurrogate_ValidInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.True(input.IsLowSurrogate());
    }
    
    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    public void IsLowSurrogate_WrongInput_ShouldBeFalse(char input)
    {
        // assert
        Assert.False(input.IsLowSurrogate());
    }
    
    [Theory]
    [InlineData('\uD800')]
    [InlineData('\uDBFF')]
    [InlineData('\uD83D')]
    [InlineData('\uDC00')]
    [InlineData('\uDFFF')]
    public void IsSurrogate_ValidInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.True(input.IsSurrogate());
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
        // assert
        Assert.True(input.IsPunctuation());
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('A')]
    [InlineData('0')]
    public void IsPunctuation_WrongInput_ShouldBeFalse(char input)
    {
        // assert
        Assert.False(input.IsPunctuation());
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
        // assert
        Assert.True(input.IsSeparator());
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
        // assert
        Assert.False(input.IsSeparator());
    }
    
    [Theory]
    [InlineData('A')]
    [InlineData('Z')]
    public void IsUpper_ValidInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.True(input.IsUpper());
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('z')]
    public void IsUpper_WrongInput_ShouldBeFalse(char input)
    {
        // assert
        Assert.False(input.IsUpper());
    }
    
    [Theory]
    [InlineData('a')]
    [InlineData('z')]
    public void IsLower_ValidInput_ShouldBeTrue(char input)
    {
        // assert
        Assert.True(input.IsLower());
    }
    
    [Theory]
    [InlineData('A')]
    [InlineData('Z')]
    public void IsLower_WrongInput_ShouldBeFalse(char input)
    {
        // assert
        Assert.False(input.IsLower());
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
        // assert
        Assert.True(input.IsWhiteSpace());
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
        // assert
        Assert.False(input.IsWhiteSpace());
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
        // assert
        Assert.True(input.IsSymbol());
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
        // assert
        Assert.False(input.IsSymbol());
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
        // assert
        Assert.True(input.IsControl());
    }
    
    [Theory]
    [InlineData(' ')] // Space (not a control character)
    [InlineData('A')] // Letter
    [InlineData('1')] // Digit
    [InlineData(',')] // Punctuation
    [InlineData('.')] // Punctuation
    public void IsControl_WrongInput_ShouldBeFalse(char input)
    {
        // assert
        Assert.False(input.IsControl());
    }
}