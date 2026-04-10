using System.Globalization;
using JetBrains.Annotations;
using Migs.Extensions.Chars;

namespace Migs.Extensions.UnitTests;

[TestSubject(typeof(CharExt))]
public class CharExtTests
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
    [InlineData('i', "tr-TR", 'I')]
    [InlineData('ı', "tr-TR", 'I')]
    [InlineData('ß', "de-DE", 'ß')]
    [InlineData('ς', "el-GR", 'Σ')]
    [InlineData('é', "fr-FR", 'É')]
    [InlineData('ñ', "es-ES", 'Ñ')]
    public void ToUpper_ValidInputWithCultureInfo_ShouldReturnUppercase(char input, string cultureInfo, char expected)
    {
        // arrange
        var culture = CultureInfo.GetCultureInfo(cultureInfo);
        
        // act
        var actual = input.ToUpper();
        
        // assert
        Assert.Equal(expected, actual);
    }
}