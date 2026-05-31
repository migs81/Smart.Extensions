using System.Linq.Expressions;
using System.Reflection;

namespace Migs.Extensions
{
    /// <summary>
    /// Contains extension methods for objects.
    /// </summary>
    public static class ObjectExt
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

        // /// <summary>
        // /// Clones the specified object via JSON serialization.
        // /// </summary>
        // /// <typeparam name="T"></typeparam>
        // /// <param name="obj">The object.</param>
        // /// <returns></returns>
        // /// <exception cref="System.ArgumentNullException">obj</exception>
        // public static T Clone<T>(this T obj) where T : class, new()
        // {
        //     _ = obj ?? throw new ArgumentNullException(nameof(obj));
        //
        //     string json = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
        //     {
        //         NullValueHandling = NullValueHandling.Ignore,
        //         ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        //     });
        //
        //     return JsonConvert.DeserializeObject<T>(json);
        // }

        // /// <summary>
        // /// Clones the specified object via JSON serialization.
        // /// </summary>
        // /// <typeparam name="T"></typeparam>
        // /// <param name="obj">The object.</param>
        // /// <param name="settings">The settings.</param>
        // /// <returns></returns>
        // /// <exception cref="System.ArgumentNullException">
        // /// obj
        // /// or
        // /// settings
        // /// </exception>
        // public static T Clone<T>(this T obj, JsonSerializerSettings settings) where T : class, new()
        // {
        //     _ = obj ?? throw new ArgumentNullException(nameof(obj));
        //     _ = settings ?? throw new ArgumentNullException(nameof(settings));
        //
        //     string json = JsonConvert.SerializeObject(obj, settings);
        //     return JsonConvert.DeserializeObject<T>(json);
        // }
        //
        // /// <summary>
        // /// Tries to clone the specified object via JSON serialization.
        // /// </summary>
        // /// <typeparam name="T"></typeparam>
        // /// <param name="obj">The object.</param>
        // /// <param name="result">The result.</param>
        // /// <returns></returns>
        // public static bool TryClone<T>(this T obj, out T result) where T : class, new()
        // {
        //     try
        //     {
        //         result = obj.Clone();
        //         return true;
        //     }
        //     catch (Exception)
        //     {
        //         result = null;
        //         return false;
        //     }
        // }
        //
        // /// <summary>
        // /// Tries to clone the specified object via JSON serialization.
        // /// </summary>
        // /// <typeparam name="T"></typeparam>
        // /// <param name="obj">The object.</param>
        // /// <param name="settings">The settings.</param>
        // /// <param name="result">The result.</param>
        // /// <returns></returns>
        // public static bool TryClone<T>(this T obj, JsonSerializerSettings settings, out T result) where T : class, new()
        // {
        //     try
        //     {
        //         result = obj.Clone(settings);
        //         return true;
        //     }
        //     catch (Exception)
        //     {
        //         result = null;
        //         return false;
        //     }
        // }
        //
        // /// <summary>
        // /// Computes an MD5 hash for the given object.
        // /// </summary>
        // /// <typeparam name="T"></typeparam>
        // /// <param name="obj">The object.</param>
        // /// <returns></returns>
        // /// <exception cref="System.ArgumentNullException">obj</exception>
        // public static string GetMD5<T>(this T obj) where T : class
        // {
        //     _ = obj ?? throw new ArgumentNullException(nameof(obj));
        //
        //     // serialize the object if it is not already a string!
        //     if (obj is not string value)
        //         value = JsonConvert.SerializeObject(obj);
        //
        //     using MD5 md5 = MD5.Create();
        //     byte[] bytes = md5.ComputeHash(Encoding.ASCII.GetBytes(value));
        //
        //     StringBuilder sb = new();
        //     for (int i = 0; i < bytes.Length; i++)
        //         sb.Append(bytes[i].ToString("X2"));
        //
        //     return sb.ToString().ToUpper();
        // }
        //
        // /// <summary>
        // /// Converts the given object to XML.
        // /// </summary>
        // /// <typeparam name="T"></typeparam>
        // /// <param name="obj">The object.</param>
        // /// <returns></returns>
        // /// <exception cref="System.ArgumentNullException">obj</exception>
        // public static string ToXML<T>(this T obj) where T : class
        // {
        //     _ = obj ?? throw new ArgumentNullException(nameof(obj));
        //
        //     XmlSerializer serializer = new(typeof(T));
        //     using Utf8StringWriter stringWriter = new();
        //     serializer.Serialize(stringWriter, obj);
        //     return stringWriter.ToString();
        // }
        //
        // /// <summary>
        // /// Converts the given object to JSON.
        // /// </summary>
        // /// <typeparam name="T"></typeparam>
        // /// <param name="obj">The object.</param>
        // /// <returns></returns>
        // /// <exception cref="System.ArgumentNullException">obj</exception>
        // public static string ToJson<T>(this T obj) where T : class
        // {
        //     _ = obj ?? throw new ArgumentNullException(nameof(obj));
        //
        //     return JsonConvert.SerializeObject(obj,
        //         new JsonSerializerSettings 
        //         {
        //             NullValueHandling = NullValueHandling.Ignore, 
        //             ReferenceLoopHandling = ReferenceLoopHandling.Ignore 
        //         });
        // }
        //
        // /// <summary>
        // /// Converts the given object to JSON.
        // /// </summary>
        // /// <typeparam name="T"></typeparam>
        // /// <param name="obj">The object.</param>
        // /// <param name="settings">The settings.</param>
        // /// <returns></returns>
        // /// <exception cref="System.ArgumentNullException">
        // /// obj
        // /// or
        // /// settings
        // /// </exception>
        // public static string ToJson<T>(this T obj, JsonSerializerSettings settings) where T : class
        // {
        //     _ = obj ?? throw new ArgumentNullException(nameof(obj));
        //     _ = settings ?? throw new ArgumentNullException(nameof(settings));
        //
        //     return JsonConvert.SerializeObject(obj, settings);
        // }

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
