using System.Linq.Expressions;

namespace Migs.Extensions
{
    public static class IntegerExt
    {
        public static int Change(this int arg, Expression<Func<int, int>> expression)
        {
            return expression.Compile().Invoke(arg);
        }

        public static int Random(this int arg) => Guid.NewGuid().GetHashCode();
        
        //public static bool IsZero(this short arg) => arg == 0;

        //public static bool IsZero(this int arg) => arg == 0;

        //public static bool IsZero(this long arg) => arg == 0;

        //public static bool IsZero(this double arg) => arg == 0;

        //public static bool IsZero(this float arg) => arg == 0;

        //public static bool IsZero(this uint arg) => arg == 0;

        //public static bool IsZero(this ulong arg) => arg == 0;

        //public static bool IsGreater(this short arg, short value) => arg > value;

        public static short Add(this short arg, short value) => (short)(arg + value);

        public static int Add(this int arg, int value) => arg + value;

        public static long Add(this long arg, long value) => arg + value;

        public static double Add(this double arg, double value) => arg + value;

        public static float Add(this float arg, float value) => arg + value;

        /// <summary>
        /// Adds the given value to arg considering the given maximum.
        /// Ensures that it does not go over uint.MaxValue!
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="value"></param>
        /// <param name="max">should be greater then arg</param>
        /// <returns></returns>
        public static uint Add(this uint arg, uint value, uint max = uint.MaxValue)
        {
            if(max > arg)
            {
                if (value < (max - arg))
                    return arg + value;
                else
                    return uint.MaxValue;
            }
            else
            {
                return arg;
            }
        }

        /// <summary>
        /// Adds the given value to arg considering the given maximum.
        /// Ensures that it does not go over uint.MaxValue!
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="value"></param>
        /// <param name="overflow"></param>
        /// <param name="max">should be greater then arg</param>
        /// <returns></returns>
        public static uint Add(this uint arg, uint value, out uint overflow, uint max = uint.MaxValue)
        {
            if (max > arg)
            {
                if (value < (max - arg))
                {
                    overflow = 0;
                    return arg + value;
                }
                else
                {
                    overflow = (max - arg - value);
                    return uint.MaxValue;
                }
            }
            else
            {
                overflow = 0;
                return arg;
            }
        }

        /// <summary>
        /// Subtracts the given value from arg.
        /// Ensures that it does not go below zero!
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static uint Subtract(this uint arg, uint value)
        {
            if (value < arg)
                return (arg - value);
            else
                return 0;
        }
        
        public static int DivideBy(this int arg, int value) => arg / value;

        public static int MultiplyWith(this int arg, int value) => arg / value;
    }
}
