using JetBrains.Annotations;

namespace Migs.Extensions.UnitTests;

[TestSubject(typeof(ObjectExt))]
public class ObjectExtTest
{
    #region GetValueOrDefault

    [Fact]
    public void GetValueOrDefault_ValidInput_ShouldReturnValue()
    {
        // arrange
        var list = new List<string>() { "a", "b", "c" };
        
        // act
        var result = list.GetValueOrDefault();
        
        // assert
        Assert.NotNull(result);
    }
    
    [Fact]
    public void GetValueOrDefault_WrongInput_ShouldReturnDefaultValue()
    {
        // arrange
        List<string> list = null;
        
        // act
        var result = list.GetValueOrDefault();
        
        // assert
        Assert.Null(result);
    }
    
    #endregion

    #region GetOrSetValue
    
    [Fact]
    public void GetOrSetValue_NullSource_ShouldReturnValue()
    {
        // arrange
        List<string> source = null;
        var value = new List<string>() { "a", "b", "c" };
        
        // act
        var result = source.GetOrSetValue(value);
        
        // assert
        Assert.Equal(value, result);
    }
    
    [Fact]
    public void GetOrSetValue_NullValue_ShouldReturnSource()
    {
        // arrange
        List<string> source = null;
        List<string> value = null;
        
        // act
        var result = source.GetOrSetValue(value);
        
        // assert
        Assert.Null(result);
    }
    
    [Fact]
    public void GetOrSetValue_ValidInput_ShouldReturnSource()
    {
        // arrange
        var list1 = new List<string>() { "a", "b" };
        var list2 = new List<string>() { "a", "b", "c" };
        
        // act
        var result = list1.GetOrSetValue(list2);
        
        // assert
        Assert.Equal(list1, result);
    }
    
    #endregion

    #region ReplaceIf

    [Fact]
    public void ReplaceIf_NullValue_ShouldThrowException()
    {
        // arrange
        string source = null;
        const string value = "new";
        
        // assert
        Assert.Throws<NullReferenceException>(() => source.ReplaceIf(_ => source.Length == 3, "new"));
    }
    
    [Fact]
    public void ReplaceIf_WrongInput_ShouldReturnSource()
    {
        // arrange
        const string source = "old";
        const string value = "new";
        
        // act
        var result = source.ReplaceIf(_ => source == "old2", "new");
        
        // assert
        Assert.NotEqual(value, result);
        Assert.Equal(source, result);
    }
    
    [Fact]
    public void ReplaceIf_ValidInput_ShouldReturnNewValue()
    {
        // arrange
        const string source = "old";
        const string value = "new";
        
        // act
        var result = source.ReplaceIf(_ => source =="old", "new");
        
        // assert
        Assert.NotEqual(value, result);
        Assert.Equal(value, result);
    }
    
    #endregion
    
    #region If

    // [Fact]
    // public void If_NullValue_ShouldThrowException()
    // {
    //     // arrange
    //     string source = null;
    //     const string value = "new";
    //     
    //     // assert
    //     Assert.Throws<NullReferenceException>(() => source.If(_ => source.Length == 3, source.Count()));
    // }
    //
    
    #endregion
}