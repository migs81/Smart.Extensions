using System.Collections.ObjectModel;
using JetBrains.Annotations;
using Migs.Extensions.Collections;

namespace Migs.Extensions.UnitTests;

[TestSubject(typeof(CollectionExt))]
public class CollectionExtTests
{
    [Fact]
    public void IsNullOrEmpty_ValidInput_ShouldReturnFalse()
    {
        // arrange
        var list = new List<int> { 1 };
        
        // assert
        Assert.False(list.IsNullOrEmpty());
    }
    
    [Fact]
    public void IsNullOrEmpty_WrongInput_ShouldReturnTrue()
    {
        // arrange
        var list = new List<int>();
        string[] array = null;
        
        // assert
        Assert.True(list.IsNullOrEmpty());
        Assert.True(CollectionExt.IsNullOrEmpty(array));
    }

    [Fact]
    public void IsNull_ValidInput_ShouldReturnFalse()
    {
        // arrange
        string[] array = [""];
        
        // assert
        Assert.False(array.IsNull());
    }
    
    [Fact]
    public void IsNull_NullInput_ShouldReturnTrue()
    {
        // arrange
        string[] array = null;
        
        // assert
        Assert.True(array.IsNull());
    }

    [Fact]
    public void AddRange_ValidInput_ShouldReturnCollection()
    {
        // arrange
        var list1 = new List<int> { 1, 2, 3 };
        var list2 = new List<int> { 4, 5, 6 };
        
        // act
        list1.AddRange(list2);
        
        // assert
        Assert.Equal(6, list1.Count);
        for (var i = 0; i < list1.Count; i++)
            Assert.Equal(i+1, list1[i]);
    }
    
    [Fact]
    public void AddRange_NullInput_ShouldThrowException()
    {
        // arrange
        ObservableCollection<string> list = null;
        ObservableCollection<string> list2 = [""];
        
        // assert
        Assert.Throws<ArgumentNullException>(() => list.AddRange(list2));
        Assert.Throws<ArgumentNullException>(() => list2.AddRange(list));
    }

    [Fact]
    public void ToObservableCollection_ValidInput_ShouldReturnObservableCollection()
    {
        // arrange
        var list = new List<int> { 1, 2, 3 };
        
        // act
        var collection = list.ToObservableCollection();
        
        // assert
        Assert.IsType<ObservableCollection<int>>(collection);
    }

    [Fact]
    public void ToObservableCollection_NullInput_ShouldThrowException()
    {
        // arrange
        List<string> list = null;
        
        // assert
        Assert.Throws<ArgumentNullException>(() => list.ToObservableCollection());
    }
}