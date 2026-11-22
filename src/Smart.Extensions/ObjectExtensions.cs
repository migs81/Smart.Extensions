using System.Linq.Expressions;
using System.Reflection;

namespace Smart.Extensions
{
    /// <summary>
    /// Contains extension methods for objects.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Gets the value or default.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static T? GetValueOrDefault<T>(this T obj) where T : new() => obj is null ? default : obj;

        /// <summary>
        /// Gets the value or returns the specified one.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static T GetOrSetValue<T>(this T obj, T value) => obj is null ? value : obj;

        /// <summary>
        /// Replaces the object if the given expression is true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="newValue">The new value.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">expression</exception>
        public static T ReplaceIf<T>(this T obj, Expression<Func<T, bool>> expression, T newValue)
        {
            _ = expression ?? throw new ArgumentNullException(nameof(expression));

            return expression.Compile().Invoke(obj) ? newValue : obj;
        }

        /// <summary>
        /// If the condition is met, the specified action will be performed on the given object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="condition">The predicate.</param>
        /// <param name="func">The action</param>
        /// <returns></returns>
        public static T If<T>(this T obj, Func<T, bool> condition, Func<T, T> func) where T : class
        {
            if (condition.Invoke(obj))
                return func.Invoke(obj);

            return obj;
        }

        /// <summary>
        /// Determines all properties of the source considering the specified target type and predicate.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TTarget">The type of the target.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">predicate</exception>
        public static List<KeyValuePair<string, TTarget>> GetPropertyValues<TSource, TTarget>(this TSource source, Func<PropertyInfo, bool> predicate)
            where TSource : class 
            where TTarget : class
        {
            _ = predicate ?? throw new ArgumentNullException(nameof(predicate));

            var result =  new List<KeyValuePair<string, TTarget>>();
            
            foreach(var property in typeof(TSource).GetProperties().Where(predicate))
            {
                if (property.GetValue(source) is TTarget targetValue)
                    result.Add(new KeyValuePair<string, TTarget>(property.Name, targetValue));
            }

            return result;
        }
    }
}
