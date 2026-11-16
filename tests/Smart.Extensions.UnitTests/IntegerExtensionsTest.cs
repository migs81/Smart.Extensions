using JetBrains.Annotations;

namespace Smart.Extensions.UnitTests;

[TestSubject(typeof(IntegerExtensions))]
public class IntegerExtensionsTest
{
    #region IsZero

    [Fact]
    public void IsZero_ValidInput_ShouldReturnTrue()
    {
        // arrange
        const int value = 0;
        
        // act
        var result = value.IsZero();
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(100)]
    public void IsZero_WrongInput_ShouldReturnFalse(int value)
    {
        // arrange
        var expected = value == 0;
        
        // act
        var result = value.IsZero();
        
        // assert
        Assert.False(expected);
        Assert.Equal(expected, result);
    }
    
    #endregion

    #region IsNegative

    [Theory]
    [InlineData(-1)]
    [InlineData(-100)]
    public void IsNegative_ValidInput_ShouldReturnTrue(int value)
    {
        // act
        var result = value.IsNegative();
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(100)]
    public void IsNegative_WrongInput_ShouldReturnFalse(int value)
    {
        // act
        var result = value.IsNegative();
        
        // assert
        Assert.False(result);
    }

    #endregion

    #region IsPositive

    [Theory]
    [InlineData(1)]
    [InlineData(100)]
    public void IsPositive_ValidInput_ShouldReturnTrue(int value)
    {
        // act
        var result = value.IsPositive();
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-100)]
    public void IsPositive_WrongInput_ShouldReturnFalse(int value)
    {
        // act
        var result = value.IsPositive();
        
        // assert
        Assert.False(result);
    }

    #endregion

    #region IsGreaterThan

    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, short.MinValue)]
    public void IsGreaterThan_Short_ValidInput_ShouldReturnTrue(int source, short value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(int.MinValue, 0)]
    public void IsGreaterThan_Short_WrongInput_ShouldReturnFalse(int source, short value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, int.MinValue)]
    public void IsGreaterThan_Integer_ValidInput_ShouldReturnTrue(int source, int value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(int.MinValue, 0)]
    public void IsGreaterThan_Integer_WrongInput_ShouldReturnFalse(int source, int value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(1, 0L)]
    [InlineData(0, long.MinValue)]
    public void IsGreaterThan_Long_ValidInput_ShouldReturnTrue(int source, long value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, 1L)]
    [InlineData(int.MinValue, 0L)]
    public void IsGreaterThan_Long_WrongInput_ShouldReturnFalse(int source, long value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, double.MinValue)]
    public void IsGreaterThan_Double_ValidInput_ShouldReturnTrue(int source, double value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(0, double.MaxValue)]
    [InlineData(int.MinValue, 0)]
    public void IsGreaterThan_Double_WrongInput_ShouldReturnFalse(int source, double value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, float.MinValue)]
    public void IsGreaterThan_Float_ValidInput_ShouldReturnTrue(int source, float value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(0, float.MaxValue)]
    [InlineData(int.MinValue, 0)]
    public void IsGreaterThan_Float_WrongInput_ShouldReturnFalse(int source, float value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(1, 0)]
    [InlineData(int.MaxValue, uint.MinValue)]
    public void IsGreaterThan_UInt_ValidInput_ShouldReturnTrue(int source, uint value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(0, uint.MaxValue)]
    [InlineData(int.MinValue, 0)]
    public void IsGreaterThan_UInt_WrongInput_ShouldReturnFalse(int source, uint value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(1, 0)]
    [InlineData(int.MaxValue, ulong.MinValue)]
    public void IsGreaterThan_ULong_ValidInput_ShouldReturnTrue(int source, ulong value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(0, ulong.MaxValue)]
    [InlineData(int.MinValue, 0)]
    public void IsGreaterThan_ULong_WrongInput_ShouldReturnFalse(int source, ulong value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(1, 0)]
    public void IsGreaterThan_Decimal_ValidInput_ShouldReturnTrue(int source, decimal value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(int.MinValue, 0)]
    public void IsGreaterThan_Decimal_WrongInput_ShouldReturnFalse(int source, decimal value)
    {
        // act
        var result = source.IsGreaterThan(value);
        
        // assert
        Assert.False(result);
    }
    
    #endregion
    
    #region IsLessThan

    [Theory]
    [InlineData(0, 1)]
    [InlineData(0, short.MaxValue)]
    public void IsLessThan_Short_ValidInput_ShouldReturnTrue(int source, short value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(int.MaxValue, 0)]
    public void IsLessThan_Short_WrongInput_ShouldReturnFalse(int source, short value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(0, int.MaxValue)]
    public void IsLessThan_Integer_ValidInput_ShouldReturnTrue(int source, int value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(int.MaxValue, 0)]
    public void IsLessThan_Integer_WrongInput_ShouldReturnFalse(int source, int value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(0, 1L)]
    [InlineData(0, long.MaxValue)]
    public void IsLessThan_Long_ValidInput_ShouldReturnTrue(int source, long value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 0L)]
    [InlineData(int.MaxValue, 0L)]
    public void IsLessThan_Long_WrongInput_ShouldReturnFalse(int source, long value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(0, 1)]
    [InlineData(0, double.MaxValue)]
    public void IsLessThan_Double_ValidInput_ShouldReturnTrue(int source, double value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, double.MinValue)]
    [InlineData(int.MaxValue, 0)]
    public void IsLessThan_Double_WrongInput_ShouldReturnFalse(int source, double value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(0, 1)]
    [InlineData(0, float.MaxValue)]
    public void IsLessThan_Float_ValidInput_ShouldReturnTrue(int source, float value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, float.MinValue)]
    [InlineData(int.MaxValue, 0)]
    public void IsLessThan_Float_WrongInput_ShouldReturnFalse(int source, float value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(0, 1)]
    [InlineData(int.MinValue, uint.MaxValue)]
    public void IsLessThan_UInt_ValidInput_ShouldReturnTrue(int source, uint value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, uint.MinValue)]
    [InlineData(int.MaxValue, 0)]
    public void IsLessThan_UInt_WrongInput_ShouldReturnFalse(int source, uint value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(0, 1)]
    [InlineData(int.MinValue, ulong.MaxValue)]
    public void IsLessThan_ULong_ValidInput_ShouldReturnTrue(int source, ulong value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, ulong.MinValue)]
    [InlineData(int.MaxValue, 0)]
    public void IsLessThan_ULong_WrongInput_ShouldReturnFalse(int source, ulong value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.False(result);
    }
    
    [Theory]
    [InlineData(0, 1)]
    public void IsLessThan_Decimal_ValidInput_ShouldReturnTrue(int source, decimal value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(int.MaxValue, 0)]
    public void IsLessThan_Decimal_WrongInput_ShouldReturnFalse(int source, decimal value)
    {
        // act
        var result = source.IsLessThan(value);
        
        // assert
        Assert.False(result);
    }
    
    #endregion
    
    #region Add

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 1, 2)]
    [InlineData(-1, -1, -2)]
    [InlineData(int.MaxValue, 0, int.MaxValue)]
    [InlineData(int.MinValue, 0, int.MinValue)]
    [InlineData(int.MaxValue - 1, 1, int.MaxValue)]
    [InlineData(int.MinValue + 1, -1, int.MinValue)]
    [InlineData(int.MaxValue - short.MaxValue, short.MaxValue, int.MaxValue)]
    [InlineData(int.MinValue - short.MinValue, short.MinValue, int.MinValue)]
    [InlineData(1000, short.MaxValue, 33767)]
    [InlineData(-1000, short.MinValue, -33768)]
    [InlineData(int.MaxValue - 100, 100, int.MaxValue)]
    [InlineData(int.MinValue + 100, -100, int.MinValue)]
    public void Add_Short_ValidInput_ShouldReturnNewValue(int source, short value, int expected)
    {
        // act
        var result = source.Add(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, -1)]
    public void Add_Short_WrongInput_ShouldThrowException(int source, short value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Add(value));
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2, 3)]
    [InlineData(-1, -2, -3)]
    [InlineData(100, 200, 300)]
    [InlineData(-100, 50, -50)]
    [InlineData(int.MaxValue, 0, int.MaxValue)]
    [InlineData(int.MinValue, 0, int.MinValue)]
    [InlineData(int.MaxValue - 1, 1, int.MaxValue)]
    [InlineData(int.MinValue + 1, -1, int.MinValue)]
    [InlineData(0, int.MaxValue, int.MaxValue)]
    [InlineData(0, int.MinValue, int.MinValue)]
    public void Add_Integer_ValidInput_ShouldReturnNewValue(int source, int value, int expected)
    {
        // act
        var result = source.Add(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, -1)]
    public void Add_Integer_WrongInput_ShouldThrowException(int source, int value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Add(value));
    }
    
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2, 3)]
    [InlineData(-1, -2, -3)]
    [InlineData(100, 200, 300)]
    [InlineData(-100, 50, -50)]
    [InlineData(int.MaxValue, 0, int.MaxValue)]
    [InlineData(int.MinValue, 0, int.MinValue)]
    [InlineData(int.MaxValue - 1, 1, int.MaxValue)]
    [InlineData(int.MinValue + 1, -1, int.MinValue)]
    [InlineData(0, int.MaxValue, int.MaxValue)]
    [InlineData(0, int.MinValue, int.MinValue)]
    public void Add_Long_ValidInput_ShouldReturnNewValue(int source, long value, int expected)
    {
        // act
        var result = source.Add(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, -1)]
    public void Add_Long_WrongInput_ShouldThrowException(int source, long value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Add(value));
    }
    
    [Theory]
    [InlineData(0, 0.0, 0)]
    [InlineData(1, 2.0, 3)]
    [InlineData(-1, -2.0, -3)]
    [InlineData(10, 2.5, 12)]
    [InlineData(-10, 2.5, -7)]
    [InlineData(100, 0.0, 100)]
    [InlineData(-100, 0.0, -100)]
    [InlineData(int.MaxValue, 0.0, int.MaxValue)]
    [InlineData(int.MinValue, 0.0, int.MinValue)]
    [InlineData(0, 1.9, 1)]
    [InlineData(0, -1.9, -1)]
    public void Add_Double_ValidInput_ShouldReturnNewValue(int source, double value, int expected)
    {
        // act
        var result = source.Add(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, -1)]
    public void Add_Double_WrongInput_ShouldThrowException(int source, double value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Add(value));
    }
    
    [Theory]
    [InlineData(0, 0.0, 0)]
    [InlineData(1, 2.0, 3)]
    [InlineData(-1, -2.0, -3)]
    [InlineData(10, 2.5, 12)]
    [InlineData(-10, 2.5, -7)]
    [InlineData(100, 0.0, 100)]
    [InlineData(-100, 0.0, -100)]
    [InlineData(int.MaxValue, 0.0f, int.MaxValue)]
    [InlineData(int.MinValue, 0.0, int.MinValue)]
    [InlineData(0, 1.9, 1)]
    [InlineData(0, -1.9, -1)]
    public void Add_Float_ValidInput_ShouldReturnNewValue(int source, float value, int expected)
    {
        // act
        var result = source.Add(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, -1)]
    public void Add_Float_WrongInput_ShouldThrowException(int source, float value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Add(value));
    }
    
    [Theory]
    [InlineData(0, 0u, 0)]
    [InlineData(1, 0u, 1)]
    [InlineData(10, 5u, 15)]
    [InlineData(-10, 5u, -5)]
    [InlineData(-10, 10u, 0)]
    [InlineData(int.MaxValue, 0u, int.MaxValue)]
    [InlineData(int.MinValue, 0u, int.MinValue)]
    [InlineData(int.MaxValue - 1, 1u, int.MaxValue)]
    [InlineData(int.MinValue + 1, 1u, int.MinValue + 2)]
    [InlineData(100, 200u, 300)]
    [InlineData(-100, 50u, -50)]
    public void Add_UInt_ValidInput_ShouldReturnNewValue(int source, uint value, int expected)
    {
        // act
        var result = source.Add(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, uint.MaxValue)]
    public void Add_UInt_WrongInput_ShouldThrowException(int source, uint value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Add(value));
    }
    
    [Theory]
    [InlineData(0, 0ul, 0)]
    [InlineData(1, 0ul, 1)]
    [InlineData(10, 5ul, 15)]
    [InlineData(-10, 5ul, -5)]
    [InlineData(-10, 10ul, 0)]
    [InlineData(int.MaxValue, 0ul, int.MaxValue)]
    [InlineData(int.MaxValue - 1, 1ul, int.MaxValue)]
    [InlineData(int.MaxValue - 10, 10ul, int.MaxValue)]
    [InlineData(100, 200ul, 300)]
    [InlineData(-100, 50ul, -50)]
    public void Add_ULong_ValidInput_ShouldReturnNewValue(int source, ulong value, int expected)
    {
        // act
        var result = source.Add(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, ulong.MaxValue)]
    public void Add_ULong_WrongInput_ShouldThrowException(int source, ulong value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Add(value));
    }
    
    [Theory]
    [InlineData(0, 0.0, 0)]
    [InlineData(1, 0.0, 1)]
    [InlineData(10, 5.0, 15)]
    [InlineData(-10, 5.0, -5)]
    [InlineData(-10, 10.0, 0)]
    [InlineData(int.MaxValue, 0.0, int.MaxValue)]
    [InlineData(int.MinValue, 0.0, int.MinValue)]
    [InlineData(int.MaxValue - 1, 1.0, int.MaxValue)]
    [InlineData(int.MinValue + 1, 1.0, int.MinValue + 2)]
    [InlineData(100, 200.0, 300)]
    [InlineData(-100, 50.0, -50)]
    [InlineData(1, 2.5, 3)]
    [InlineData(1, 2.4, 3)]
    [InlineData(1, -2.5, -1)]
    [InlineData(1, -2.4, -1)]
    public void Add_Decimal_ValidInput_ShouldReturnNewValue(int source, decimal value, int expected)
    {
        // act
        var result = source.Add(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(int.MinValue, -1)]
    public void Add_Decimal_WrongInput_ShouldThrowException(int source, decimal value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Add(value));
    }
    
    #endregion
    
    #region Add

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(10, 5, 5)]
    [InlineData(10, -5, 15)]
    [InlineData(-10, 5, -15)]
    [InlineData(-10, -5, -5)]
    [InlineData(100, 100, 0)]
    [InlineData(-100, -100, 0)]
    [InlineData(int.MaxValue, 0, int.MaxValue)]
    [InlineData(int.MinValue, 0, int.MinValue)]
    [InlineData(int.MaxValue, 1, int.MaxValue - 1)]
    [InlineData(int.MinValue, -1, int.MinValue + 1)]
    [InlineData(int.MaxValue, short.MaxValue, int.MaxValue - short.MaxValue)]
    [InlineData(int.MinValue, short.MinValue, int.MinValue - short.MinValue)]
    public void Subtract_Short_ValidInput_ShouldReturnNewValue(int source, short value, int expected)
    {
        // act
        var result = source.Subtract(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MinValue, 1)]
    [InlineData(int.MaxValue, -1)]
    public void Subtract_Short_WrongInput_ShouldThrowException(int source, short value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Subtract(value));
    }
    
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(10, 5, 5)]
    [InlineData(10, -5, 15)]
    [InlineData(-10, 5, -15)]
    [InlineData(-10, -5, -5)]
    [InlineData(100, 100, 0)]
    [InlineData(-100, -100, 0)]
    [InlineData(int.MaxValue, 0, int.MaxValue)]
    [InlineData(int.MinValue, 0, int.MinValue)]
    [InlineData(int.MaxValue, 1, int.MaxValue - 1)]
    [InlineData(int.MinValue, -1, int.MinValue + 1)]
    [InlineData(int.MaxValue, short.MaxValue, int.MaxValue - short.MaxValue)]
    [InlineData(int.MinValue, short.MinValue, int.MinValue - short.MinValue)]
    public void Subtract_Integer_ValidInput_ShouldReturnNewValue(int source, int value, int expected)
    {
        // act
        var result = source.Subtract(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MinValue, 1)]
    [InlineData(int.MaxValue, -1)]
    public void Subtract_Integer_WrongInput_ShouldThrowException(int source, int value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Subtract(value));
    }
    
    [Theory]
    [InlineData(0, 0L, 0)]
    [InlineData(10, 5L, 5)]
    [InlineData(10, -5L, 15)]
    [InlineData(-10, 5L, -15)]
    [InlineData(-10, -5L, -5)]
    [InlineData(100, 100L, 0)]
    [InlineData(-100, -100L, 0)]
    [InlineData(int.MaxValue, 0L, int.MaxValue)]
    [InlineData(int.MinValue, 0L, int.MinValue)]
    [InlineData(int.MaxValue, 1L, int.MaxValue - 1)]
    [InlineData(int.MinValue, -1L, int.MinValue + 1)]
    [InlineData(0, int.MaxValue, -int.MaxValue)]
    [InlineData(0, int.MinValue + 1L, int.MaxValue)]
   public void Subtract_Long_ValidInput_ShouldReturnNewValue(int source, long value, int expected)
    {
        // act
        var result = source.Subtract(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MinValue, 1L)]
    [InlineData(int.MaxValue, -1L)]
    public void Subtract_Long_WrongInput_ShouldThrowException(int source, long value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Subtract(value));
    }
    
    [Theory]
    [InlineData(0, 0D, 0)]
    [InlineData(10, 5D, 5)]
    [InlineData(10, -5D, 15)]
    [InlineData(-10, 5D, -15)]
    [InlineData(-10, -5D, -5)]
    [InlineData(100, 100D, 0)]
    [InlineData(-100, -100D, 0)]
    [InlineData(int.MaxValue, 0D, int.MaxValue)]
    [InlineData(int.MinValue, 0D, int.MinValue)]
    [InlineData(int.MaxValue, 1D, int.MaxValue - 1)]
    [InlineData(int.MinValue, -1D, int.MinValue + 1)]
    [InlineData(0, int.MaxValue, -int.MaxValue)]
    [InlineData(0, int.MinValue + 1D, int.MaxValue)]
    public void Subtract_Double_ValidInput_ShouldReturnNewValue(int source, double value, int expected)
    {
        // act
        var result = source.Subtract(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MinValue, 1D)]
    [InlineData(int.MaxValue, -1D)]
    public void Subtract_Double_WrongInput_ShouldThrowException(int source, double value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Subtract(value));
    }
    
    [Theory]
    [InlineData(0, 0F, 0)]
    [InlineData(10, 5F, 5)]
    [InlineData(10, -5F, 15)]
    [InlineData(-10, 5F, -15)]
    [InlineData(-10, -5F, -5)]
    [InlineData(100, 100F, 0)]
    [InlineData(-100, -100F, 0)]
    [InlineData(int.MaxValue, 0F, int.MaxValue)]
    [InlineData(int.MinValue, 0F, int.MinValue)]
    [InlineData(int.MaxValue, 1F, int.MaxValue - 1)]
    [InlineData(int.MinValue, -1F, int.MinValue + 1)]
    [InlineData(0, 1000F, -1000)]
    [InlineData(0, -1000F, 1000)]
    public void Subtract_Float_ValidInput_ShouldReturnNewValue(int source, float value, int expected)
    {
        // act
        var result = source.Subtract(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MinValue, 1F)]
    [InlineData(int.MaxValue, -1F)]
    public void Subtract_Float_WrongInput_ShouldThrowException(int source, float value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Subtract(value));
    }
    
    [Theory]
    [InlineData(0, 0u, 0)]
    [InlineData(10, 5u, 5)]
    [InlineData(10, 10u, 0)]
    [InlineData(100, 50u, 50)]
    [InlineData(100, 100u, 0)]
    [InlineData(-10, 0u, -10)]
    [InlineData(-10, 5u, -15)]
    [InlineData(-10, 10u, -20)]
    [InlineData(int.MaxValue, 0u, int.MaxValue)]
    [InlineData(int.MinValue, 0u, int.MinValue)]
    [InlineData(int.MaxValue, 1u, int.MaxValue - 1)]
    [InlineData(int.MaxValue, 100u, int.MaxValue - 100)]
    [InlineData(int.MinValue + 100, 100u, int.MinValue)]
    [InlineData(int.MinValue + 1, 1u, int.MinValue)]
    public void Subtract_UInt_ValidInput_ShouldReturnNewValue(int source, uint value, int expected)
    {
        // act
        var result = source.Subtract(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MinValue, 1u)]
    [InlineData(int.MinValue, 100u)]
    [InlineData(int.MinValue + 10, 20u)]
    public void Subtract_UInt_WrongInput_ShouldThrowException(int source, uint value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Subtract(value));
    }
    
    [Theory]
    [InlineData(0, 0ul, 0)]
    [InlineData(10, 5ul, 5)]
    [InlineData(10, 10ul, 0)]
    [InlineData(100, 50ul, 50)]
    [InlineData(100, 100ul, 0)]
    [InlineData(-10, 0ul, -10)]
    [InlineData(-10, 5ul, -15)]
    [InlineData(-10, 10ul, -20)]
    [InlineData(int.MaxValue, 0ul, int.MaxValue)]
    [InlineData(int.MinValue, 0ul, int.MinValue)]
    [InlineData(int.MaxValue, 1ul, int.MaxValue - 1)]
    [InlineData(int.MaxValue, 100ul, int.MaxValue - 100)]
    [InlineData(int.MinValue + 100, 100ul, int.MinValue)]
    [InlineData(int.MinValue + 1, 1ul, int.MinValue)]
    public void Subtract_ULong_ValidInput_ShouldReturnNewValue(int source, ulong value, int expected)
    {
        // act
        var result = source.Subtract(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MinValue, 1ul)]
    [InlineData(int.MinValue, 100ul)]
    [InlineData(int.MinValue + 10, 20ul)]
    [InlineData(0, (ulong)int.MaxValue + 1)]
    public void Subtract_ULong_WrongInput_ShouldThrowException(int source, ulong value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Subtract(value));
    }
    
    [Theory]
    [InlineData(0, 0.0, 0)]
    [InlineData(10, 5.0, 5)]
    [InlineData(10, -5.0, 15)]
    [InlineData(-10, 5.0, -15)]
    [InlineData(-10, -5.0, -5)]
    [InlineData(100, 100.0, 0)]
    [InlineData(-100, -100.0, 0)]
    [InlineData(int.MaxValue, 0.0, int.MaxValue)]
    [InlineData(int.MinValue, 0.0, int.MinValue)]
    [InlineData(int.MaxValue, 1.0, int.MaxValue - 1)]
    [InlineData(int.MinValue, -1.0, int.MinValue + 1)]
    [InlineData(0, 1.5, -1)]
    [InlineData(0, -1.5, 1)]
    [InlineData(1, 2.9, -1)]
    [InlineData(1, 2.1, -1)]
    [InlineData(1, -2.9, 3)]
    [InlineData(1, -2.1, 3)]
    public void Subtract_Decimal_ValidInput_ShouldReturnNewValue(int source, decimal value, int expected)
    {
        // act
        var result = source.Subtract(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, -1.0)]
    [InlineData(int.MinValue, 1.0)]
    public void Subtract_Decimal_WrongInput_ShouldThrowException(int source, decimal value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.Subtract(value));
    }
    
    #endregion
    
    #region DivideBy
    
    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(10, -2, -5)]
    [InlineData(-10, 2, -5)]
    [InlineData(-10, -2, 5)]
    [InlineData(5, 2, 2)]
    [InlineData(7, 3, 2)]
    public void DivideBy_Short_ValidInput_ShouldReturnNewValue(int source, short value, int expected)
    {
        // act
        var result = source.DivideBy(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 0)]
    [InlineData(-10, 0)]
    public void DivideBy_Short_WrongInput_ShouldThrowException(int source, short value)
    {
        // assert
        Assert.Throws<DivideByZeroException>(() => source.DivideBy(value));
    }
    
    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(10, -2, -5)]
    [InlineData(-10, 2, -5)]
    [InlineData(-10, -2, 5)]
    [InlineData(5, 2, 2)]
    public void DivideBy_Int_ValidInput_ShouldReturnNewValue(int source, int value, int expected)
    {
        // act
        var result = source.DivideBy(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 0)]
    [InlineData(-10, 0)]
    public void DivideBy_Int_WrongInput_ShouldThrowException(int source, int value)
    {
        // assert
        Assert.Throws<DivideByZeroException>(() => source.DivideBy(value));
    }

    [Theory]
    [InlineData(10, 2L, 5)]
    [InlineData(10, -2L, -5)]
    [InlineData(-10, 2L, -5)]
    [InlineData(-10, -2L, 5)]
    public void DivideBy_Long_ValidInput_ShouldReturnNewValue(int source, long value, int expected)
    {
        // act
        var result = source.DivideBy(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 0L)]
    public void DivideBy_Long_WrongInput_ShouldThrowException(int source, long value)
    {
        Assert.Throws<DivideByZeroException>(() => source.DivideBy(value));
    }

    [Theory]
    [InlineData(10, 2u, 5)]
    [InlineData(10, 5u, 2)]
    [InlineData(5, 2u, 2)]
    [InlineData(10, uint.MaxValue, 0)]
    public void DivideBy_UInt_ValidInput_ShouldReturnNewValue(int source, uint value, int expected)
    {
        // act
        var result = source.DivideBy(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 0u)]
    public void DivideBy_UInt_WrongInput_ShouldThrowException(int source, uint value)
    {
        // assert
        Assert.Throws<DivideByZeroException>(() => source.DivideBy(value));
    }

    [Theory]
    [InlineData(10, 2ul, 5)]
    [InlineData(10, 5ul, 2)]
    [InlineData(10, ulong.MaxValue, 0)]
    public void DivideBy_Ulong_ValidInput_ShouldReturnNewValue(int source, ulong value, int expected)
    {
        // act
        var result = source.DivideBy(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 0ul)]
    public void DivideBy_Ulong_WrongInput_ShouldThrowException(int source, ulong value)
    {
        // assert
        Assert.Throws<DivideByZeroException>(() => source.DivideBy(value));
    }

    [Theory]
    [InlineData(10, 2f, 5)]
    [InlineData(10, -2f, -5)]
    [InlineData(5, 2f, 2)]
    public void DivideBy_Float_ValidInput_ShouldReturnNewValue(int source, float value, int expected)
    {
        // act
        var result = source.DivideBy(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DivideBy_Float_Invalid_NaN()
    {
        // assert
        Assert.Throws<OverflowException>(() => 10.DivideBy(float.NaN));
    }

    [Theory]
    [InlineData(10, 2.0, 5)]
    [InlineData(10, -2.0, -5)]
    [InlineData(5, 2.0, 2)]
    public void DivideBy_Double_ValidInput_ShouldReturnNewValue(int source, double value, int expected)
    {
        // act
        var result = source.DivideBy(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DivideBy_Double_Invalid_NaN()
    {
        // assert
        Assert.Throws<OverflowException>(() => 10.DivideBy(double.NaN));
    }

    [Theory]
    [InlineData(10, 2.0, 5)]
    [InlineData(10, -2.0, -5)]
    [InlineData(7, 2.0, 3)]
    [InlineData(7, 3.0, 2)]
    public void DivideBy_Decimal_ValidInput_ShouldReturnNewValue(int source, decimal value, int expected)
    {
        // act
        var result = source.DivideBy(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DivideBy_Decimal_DivideByZero()
    {
        // assert
        Assert.Throws<DivideByZeroException>(() => 10.DivideBy(0m));
    }

    #endregion

    #region MultiplyWith

    [Theory]
    [InlineData(10, 2, 20)]
    [InlineData(10, -2, -20)]
    [InlineData(7, 3, 21)]
    public void MultiplyWith_Short_ValidInput_ShouldReturnNewValue(int source, short value, int expected)
    {
        // act
        var result = source.MultiplyWith(value);
        
        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, short.MaxValue)]
    [InlineData(int.MinValue, short.MinValue)]
    public void MultiplyWith_Short_WrongInput_ShouldThrowException(int source, short value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.MultiplyWith(value));
    }
    
    [Theory]
    [InlineData(10, 2, 20)]
    [InlineData(10, -2, -20)]
    [InlineData(7, 3, 21)]
    public void MultiplyWith_Integer_ValidInput_ShouldReturnNewValue(int source, int value, int expected)
    {
        // act
        var result = source.MultiplyWith(value);

        // assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(int.MaxValue, int.MaxValue)]
    [InlineData(int.MinValue, int.MinValue)]
    public void MultiplyWith_Integer_WrongInput_ShouldThrowException(int source, int value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.MultiplyWith(value));
    }
    
    [Theory]
    [InlineData(10, 2, 20)]
    [InlineData(10, -2, -20)]
    [InlineData(7, 3, 21)]
    public void MultiplyWith_Long_ValidInput_ShouldReturnNewValue(int source, long value, int expected)
    {
        // act
        var result = source.MultiplyWith(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(int.MaxValue, long.MaxValue)]
    [InlineData(int.MinValue, long.MinValue)]
    public void MultiplyWith_Long_WrongInput_ShouldThrowException(int source, long value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.MultiplyWith(value));
    }
    
    [Theory]
    [InlineData(10, 2.0, 20)]
    [InlineData(7, 2.5, 17)]
    public void MultiplyWith_Double_ValidInput_ShouldReturnNewValue(int source, double value, int expected)
    {
        // act
        var result = source.MultiplyWith(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(int.MaxValue, double.NaN)]
    [InlineData(int.MaxValue, double.PositiveInfinity)]
    [InlineData(int.MinValue, double.NegativeInfinity)]
    public void MultiplyWith_Double_WrongInput_ShouldThrowException(int source, double value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.MultiplyWith(value));
    }

    [Theory]
    [InlineData(10, 2f, 20)]
    [InlineData(7, 2.5f, 17)]
    public void MultiplyWith_Float_ValidInput_ShouldReturnNewValue(int source, float value, int expected)
    {
        // act
        var result = source.MultiplyWith(value);
        
        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(int.MaxValue, float.NaN)]
    [InlineData(int.MaxValue, float.PositiveInfinity)]
    [InlineData(int.MinValue, float.NegativeInfinity)]
    public void MultiplyWith_Float_NaN_ShouldThrow(int source, float value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.MultiplyWith(value));
    }

    [Theory]
    [InlineData(10u, 2u, 20)]
    public void MultiplyWith_UInt_ValidInput_ShouldReturnNewValue(int source, uint value, int expected)
    {
        // act
        var result = source.MultiplyWith(value);

        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(int.MaxValue, uint.MaxValue)]
    [InlineData(int.MinValue, uint.MaxValue)]
    public void MultiplyWith_UInt_WrongInput_ShouldThrowException(int source, uint value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.MultiplyWith(value));
    }
    
    [Theory]
    [InlineData(10, 2, 20)]
    [InlineData(7, 3, 21)]
    public void MultiplyWith_Decimal_ValidInput_ShouldReturnNewValue(int source, decimal value, int expected)
    {
        // act
        var result = source.MultiplyWith(value);

        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(int.MaxValue, long.MaxValue)]
    [InlineData(int.MinValue, long.MaxValue)]
    public void MultiplyWith_Decimal_WrongInput_ShouldThrowException(int source, decimal value)
    {
        // assert
        Assert.Throws<OverflowException>(() => source.MultiplyWith(value));
    }
    
    #endregion
}