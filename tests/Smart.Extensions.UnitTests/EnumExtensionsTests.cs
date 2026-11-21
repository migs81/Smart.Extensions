using System.ComponentModel;
using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(EnumExtensions))]
public class EnumExtensionsTests
{
    private enum Level
    {
        Low = 0,
        
        [Description("Medium level")]
        Medium,
        
        [Description("High level")]
        High,
    }
    
    #region GetDescription

    [Fact]
    public void GetDescription_WhenDescriptionExists_ReturnsDescription()
    {
        // arrange
        const Level level = Level.Medium;

        // act
        var description = level.GetDescription();
        
        // assert
        Assert.Equal("Medium level", description);
    }
    
    [Fact]
    public void GetDescription_WhenNoDescriptionExists_ReturnsEmptyString()
    {
        // arrange
        const Level level = Level.Low;

        // act
        var description = level.GetDescription();
        
        // assert
        Assert.Equal("", description);
    }
    
    [Fact]
    public void GetDescription_WhenInputIsNull_Throws()
    {
        // arrange
        string? value = null;

        // act
        var result = Record.Exception(() => value!.GetDescription());
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    [Fact]
    public void GetDescription_WhenInputIsNoEnum_Throws()
    {
        // arrange
        const string value = "";

        // act
        var result = Record.Exception(() => value.GetDescription());
        
        // assert
        Assert.IsType<ArgumentException>(result);
    }
    
    #endregion
    
    #region GetName
    
    [Fact]
    public void GetName_WhenInputIsEnum_ReturnsDescription()
    {
        // arrange
        const Level level = Level.Medium;

        // act
        var name = level.GetName();
        
        // assert
        Assert.Equal("Medium", name);
    }
    
    [Fact]
    public void GetName_WhenInputIsNull_Throws()
    {
        // arrange
        string? value = null;

        // act
        var result = Record.Exception(() => value!.GetName());
        
        // assert
        Assert.IsType<ArgumentNullException>(result);
    }
    
    [Fact]
    public void GetName_WhenInputIsNoEnum_Throws()
    {
        // arrange
        const string value = "";

        // act
        var result = Record.Exception(() => value.GetName());
        
        // assert
        Assert.IsType<ArgumentException>(result);
    }
    
    #endregion
}