using System.ComponentModel;
using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(EnumExtensions))]
public class EnumExtensionsTest
{
    private enum EnumWithDescription
    {
        [Description("Test")]
        Value1,
    }
    
    private enum EnumWithoutDescription
    {
        Value1,
    }
    
    [Fact]
    public void Description_ValidInput_ShouldReturnDescription()
    {
        // assert
        Assert.Equal("Test", EnumWithDescription.Value1.Description());
    }

    [Fact]
    public void Description_WrongInput_ShouldReturnEmptyString()
    {
        // assert
        Assert.Equal("", EnumWithoutDescription.Value1.Description());
    }
    
    [Fact]
    public void Description_WrongInput_ShouldThrowException()
    {
        // arrange
        var dateTime =  DateTime.Now;
        
        // Assert
        Assert.Throws<ArgumentException>(() => dateTime.Description());
    }
}