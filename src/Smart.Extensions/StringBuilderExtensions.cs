using System.Text;

namespace Smart.Extensions
{
    /// <summary>
    /// Contains extension methods for StringBuilder.
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Appends the given value if the condition is true.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="condition"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StringBuilder AppendIf(this StringBuilder source, bool condition, string value) 
            => condition && value is not null ? source.Append(value) : source;

        /// <summary>
        /// Appends the given value as new line if the condition is true.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="condition"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StringBuilder AppendLineIf(this StringBuilder source, bool condition, string value) 
            => condition && value is not null ? source.AppendLine(value) : source;

        /// <summary>
        /// Appends the given value if it is not null or empty.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StringBuilder AppendIfNotNullOrEmpty(this StringBuilder source, string value) 
            => !string.IsNullOrEmpty(value) ? source.Append(value) : source;

        /// <summary>
        /// Appends the given value as new line if it is not null or empty.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StringBuilder AppendLineIfNotNullOrEmpty(this StringBuilder source, string value) 
            => !string.IsNullOrEmpty(value) ? source.AppendLine(value) : source;

        /// <summary>
        /// Appends a new line for each string in the collection.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static StringBuilder AppendLines(this StringBuilder source, IEnumerable<string> collection)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (collection != null)
            {
                foreach(var value in collection)
                    source.AppendLine(value);
            }

            return source;
        }

        /// <summary>
        /// Returns a value indicating whether a specified substring occurs within this string.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool Contains(this StringBuilder source, string value)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));
            
            return source.ToString().Contains(value);
        }
        
        /// <summary>
        /// Returns a value indicating whether a specified substring occurs within this string.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <param name="comparison"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool Contains(this StringBuilder source, string value, StringComparison comparison)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));
            
            return source.ToString().IndexOf(value, comparison) != -1;
        }
    }
}
