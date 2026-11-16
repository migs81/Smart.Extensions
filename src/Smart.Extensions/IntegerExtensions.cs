namespace Smart.Extensions
{
    public static class IntegerExtensions
    {
        #region Is
        
        /// <summary>
        /// Returns whether the integer value is zero.
        /// </summary>
        /// <param name="source">The value to evaluate.</param>
        /// <returns>True if the value is 0; otherwise false.</returns>
        public static bool IsZero(this int source) => source == 0;
        
        /// <summary>
        /// Returns whether the value is negative.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns><c>true</c> if the value is less than 0; otherwise, <c>false</c>.</returns>
        public static bool IsNegative(this int value) => value < 0;

        /// <summary>
        /// Returns whether the value is positive.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns><c>true</c> if the value is greater than 0; otherwise, <c>false</c>.</returns>
        public static bool IsPositive(this int value) => value > 0;
       
        /// <summary>
        /// Returns whether the value is greater than the specified <see cref="short"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is greater than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan(this int source, short value) => source > value;
        
        /// <summary>
        /// Returns whether the value is greater than the specified <see cref="int"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is greater than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan(this int source, int value) => source > value;
        
        /// <summary>
        /// Returns whether the value is greater than the specified <see cref="long"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is greater than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan(this int source, long value) => source > value;
        
        /// <summary>
        /// Returns whether the value is greater than the specified <see cref="double"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is greater than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan(this int source, double value) => source > value;
        
        /// <summary>
        /// Returns whether the value is greater than the specified <see cref="float"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is greater than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan(this int source, float value) => source > value;
        
        /// <summary>
        /// Returns whether the value is greater than the specified <see cref="uint"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is greater than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan(this int source, uint value) => source > value;
        
        /// <summary>
        /// Returns whether the value is greater than the specified <see cref="ulong"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is greater than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan(this int source, ulong value) => source >= 0 && (ulong)source > value;
        
        /// <summary>
        /// Returns whether the value is greater than the specified <see cref="decimal"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is greater than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan(this int source, decimal value) => source > value;
        
        /// <summary>
        /// Returns whether the value is less than the specified <see cref="short"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is less than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLessThan(this int source, short value) => source < value;
        
        /// <summary>
        /// Returns whether the value is less than the specified <see cref="int"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is less than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLessThan(this int source, int value) => source < value;
        
        /// <summary>
        /// Returns whether the value is less than the specified <see cref="long"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is less than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLessThan(this int source, long value) => source < value;
        
        /// <summary>
        /// Returns whether the value is less than the specified <see cref="double"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is less than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLessThan(this int source, double value) => source < value;
        
        /// <summary>
        /// Returns whether the value is less than the specified <see cref="float"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is less than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLessThan(this int source, float value) => source < value;
        
        /// <summary>
        /// Returns whether the value is less than the specified <see cref="uint"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is less than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLessThan(this int source, uint value) => source < value;
        
        /// <summary>
        /// Returns whether the value is less than the specified <see cref="ulong"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is less than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLessThan(this int source, ulong value) => source < 0 || (ulong)source < value;
        
        /// <summary>
        /// Returns whether the value is less than the specified <see cref="decimal"/> value.
        /// </summary>
        /// <param name="source">The value to compare.</param>
        /// <param name="value">The value to compare against.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="source"/> is less than <paramref name="value"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLessThan(this int source, decimal value) => source < value;

        #endregion

        #region Add

        /// <summary>
        /// Adds the specified <see cref="short"/> value to the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the addition exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Add(this int source, short value) => checked(source + value);
        
        /// <summary>
        /// Adds the specified <see cref="int"/> value to the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the addition exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Add(this int source, int value) => checked(source + value);
        
        /// <summary>
        /// Adds the specified <see cref="long"/> value to the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the addition exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Add(this int source, long value)
        {
            var result = source + value;
            return checked((int)result);
        }
        
        /// <summary>
        /// Adds the specified <see cref="double"/> value to the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the addition exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Add(this int source, double value)
        {
            var result = source + value;

            if (result is > int.MaxValue or < int.MinValue or double.NaN)
                throw new OverflowException();

            return (int)result;
        }
        
        /// <summary>
        /// Adds the specified <see cref="float"/> value to the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the addition exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Add(this int source, float value)
        {
            var result = (double)source + value;

            if (result is > int.MaxValue or < int.MinValue or double.NaN)
                throw new OverflowException();

            return (int)result;
        }
        
        /// <summary>
        /// Adds the specified <see cref="uint"/> value to the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the addition exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Add(this int source, uint value)
        {
            if (value > int.MaxValue)
                throw new OverflowException();

            return checked(source + (int)value);
        }
        
        /// <summary>
        /// Adds the specified <see cref="ulong"/> value to the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the addition exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Add(this int source, ulong value)
        {
            if (value > int.MaxValue)
                throw new OverflowException();

            return checked(source + (int)value);
        }
        
        /// <summary>
        /// Adds the specified <see cref="decimal"/> value to the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the addition exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Add(this int source, decimal value)
        {
            var result = source + value;

            if (result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return (int)result;
        }

        #endregion
        
        #region Subtract

        /// <summary>
        /// Subtracts the specified <see cref="short"/> value from the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the subtraction exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Subtract(this int source, short value) => checked(source - value);
        
        /// <summary>
        /// Subtracts the specified <see cref="int"/> value from the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the subtraction exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Subtract(this int source, int value) => checked(source - value);
        
        /// <summary>
        /// Subtracts the specified <see cref="long"/> value from the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the subtraction exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Subtract(this int source, long value)
        {
            var result = source - value;
            return checked((int)result);
        }

        /// <summary>
        /// Subtracts the specified <see cref="double"/> value from the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the subtraction exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Subtract(this int source, double value)
        {
            var result = source - value;

            if (result is > int.MaxValue or < int.MinValue or double.NaN)
                throw new OverflowException();

            return (int)result;
        }
        
        /// <summary>
        /// Subtracts the specified <see cref="float"/> value from the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the subtraction exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Subtract(this int source, float value)
        {
            var result = (double)source - value;

            if (result is > int.MaxValue or < int.MinValue or double.NaN)
                throw new OverflowException();

            return (int)result;
        }
        
        /// <summary>
        /// Subtracts the specified <see cref="uint"/> value from the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the subtraction exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Subtract(this int source, uint value)
        {
            if (value > int.MaxValue)
                throw new OverflowException();

            return checked(source - (int)value);
        }
        
        /// <summary>
        /// Subtracts the specified <see cref="ulong"/> value from the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the subtraction exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Subtract(this int source, ulong value)
        {
            if (value > int.MaxValue)
                throw new OverflowException();

            return checked(source - (int)value);
        }
        
        /// <summary>
        /// Subtracts the specified <see cref="decimal"/> value from the current <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of the subtraction exceeds the range of <see cref="int"/>.
        /// </exception>
        public static int Subtract(this int source, decimal value)
        {
            var result = source - value;

            if (result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return (int)result;
        }

        #endregion

        #region DivideBy
        
        /// <summary>
        /// Divides the current <see cref="int"/> source by the specified <see cref="short"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public static int DivideBy(this int source, short value)
        {
            if (value == 0) 
                throw new DivideByZeroException();
            
            return source / value;
        }

        /// <summary>
        /// Divides the current <see cref="int"/> source by the specified <see cref="int"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public static int DivideBy(this int source, int value)
        {
            if (value == 0) 
                throw new DivideByZeroException();
            
            return source / value;
        }

        /// <summary>
        /// Divides the current <see cref="int"/> source by the specified <see cref="long"/> value
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static int DivideBy(this int source, long value)
        {
            if (value == 0) 
                throw new DivideByZeroException();

            var result = source / value;
            if (result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return (int)result;
        }

        /// <summary>
        /// Divides the current <see cref="int"/> source by the specified <see cref="float"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static int DivideBy(this int source, float value)
        {
            if (value == 0f) 
                throw new DivideByZeroException();

            double result = source / value;

            if (double.IsNaN(result) || double.IsInfinity(result) || result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return (int)result;
        }
        
        /// <summary>
        /// Divides the current <see cref="int"/> source by the specified <see cref="double"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static int DivideBy(this int source, double value)
        {
            if (value == 0.0) 
                throw new DivideByZeroException();

            var result = source / value;

            if (double.IsNaN(result) || double.IsInfinity(result) || result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return (int)result;
        }
        
        /// <summary>
        /// Divides the current <see cref="int"/> source by the specified <see cref="uint"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static int DivideBy(this int source, uint value)
        {
            if (value == 0) 
                throw new DivideByZeroException();

            var result = source / value;
            if (result > int.MaxValue)
                throw new OverflowException();

            return (int)result;
        }

        /// <summary>
        /// Divides the current <see cref="int"/> source by the specified <see cref="ulong"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public static int DivideBy(this int source, ulong value)
        {
            if (value == 0) 
                throw new DivideByZeroException();
            
            if (value > int.MaxValue) 
                return 0;

            var result = source / (long)value;
            
            return (int)result;
        }

        /// <summary>
        /// Divides the current <see cref="int"/> source by the specified <see cref="decimal"/> value.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static int DivideBy(this int source, decimal value)
        {
            if (value == 0m) 
                throw new DivideByZeroException();

            var result = source / value;

            if (result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return (int)result;
        }
        
        #endregion

        #region MultiplyWith

        /// <summary>
        /// Multiplies the current integer value by the specified <see cref="short"/> value.
        /// </summary>
        /// <param name="source">The value to multiply.</param>
        /// <param name="value">The multiplier.</param>
        /// <returns>The result of the multiplication.</returns>
        /// <exception cref="OverflowException">
        /// The result cannot be represented as an <see cref="int"/>.
        /// </exception>
        public static int MultiplyWith(this int source, short value) => checked(source * value);

        /// <summary>
        /// Multiplies the current integer value by the specified <see cref="int"/> value.
        /// </summary>
        /// <param name="source">The value to multiply.</param>
        /// <param name="value">The multiplier.</param>
        /// <returns>The result of the multiplication.</returns>
        /// <exception cref="OverflowException">
        /// The result cannot be represented as an <see cref="int"/>.
        /// </exception>
        public static int MultiplyWith(this int source, int value) => checked(source * value);

        /// <summary>
        /// Multiplies the current integer value by the specified <see cref="long"/> value.
        /// </summary>
        /// <param name="source">The value to multiply.</param>
        /// <param name="value">The multiplier.</param>
        /// <returns>The result of the multiplication.</returns>
        /// <exception cref="OverflowException">
        /// The result cannot be represented as an <see cref="int"/>.
        /// </exception>
        public static int MultiplyWith(this int source, long value) => checked((int)(source * value));

        /// <summary>
        /// Multiplies the current integer value by the specified <see cref="float"/> value.
        /// </summary>
        /// <param name="source">The value to multiply.</param>
        /// <param name="value">The multiplier.</param>
        /// <returns>The result of the multiplication.</returns>
        /// <exception cref="OverflowException">
        /// The result cannot be represented as an <see cref="int"/>.
        /// </exception>
        public static int MultiplyWith(this int source, float value)
        {
            if (float.IsNaN(value) || float.IsInfinity(value))
                throw new OverflowException();

            var result = source * value;
            if (result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return checked((int)result);
        }

        /// <summary>
        /// Multiplies the current integer value by the specified <see cref="uint"/> value.
        /// </summary>
        /// <param name="source">The value to multiply.</param>
        /// <param name="value">The multiplier.</param>
        /// <returns>The result of the multiplication.</returns>
        /// <exception cref="OverflowException">
        /// The result cannot be represented as an <see cref="int"/>.
        /// </exception>
        public static int MultiplyWith(this int source, uint value) => checked((int)(source * value));

        /// <summary>
        /// Multiplies the current integer value by the specified <see cref="double"/> value.
        /// </summary>
        /// <param name="source">The value to multiply.</param>
        /// <param name="value">The multiplier.</param>
        /// <returns>The result of the multiplication.</returns>
        /// <exception cref="OverflowException">
        /// The result cannot be represented as an <see cref="int"/>.
        /// </exception>
        public static int MultiplyWith(this int source, double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
                throw new OverflowException();

            var result = source * value;
            if (result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return checked((int)result);
        }
        
        /// <summary>
        /// Multiplies the current integer value by the specified <see cref="ulong"/> value.
        /// </summary>
        /// <param name="source">The value to multiply.</param>
        /// <param name="value">The multiplier.</param>
        /// <returns>The result of the multiplication.</returns>
        /// <exception cref="OverflowException">
        /// The result cannot be represented as an <see cref="int"/>.
        /// </exception>
        public static int MultiplyWith(this int source, ulong value)
        {
            if (source < 0)
                throw new OverflowException();

            return checked((int)((ulong)source * value));
        }

        /// <summary>
        /// Multiplies the current integer value by the specified <see cref="decimal"/> value.
        /// </summary>
        /// <param name="source">The value to multiply.</param>
        /// <param name="value">The multiplier.</param>
        /// <returns>The result of the multiplication.</returns>
        /// <exception cref="OverflowException">
        /// The result cannot be represented as an <see cref="int"/>.
        /// </exception>
        public static int MultiplyWith(this int source, decimal value)
        {
            var result = source * value;

            if (result is > int.MaxValue or < int.MinValue)
                throw new OverflowException();

            return (int)result;
        }
        
        #endregion
    }
}
