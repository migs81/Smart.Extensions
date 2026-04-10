using System.Collections.Generic;
using System.Text;
using System;

namespace Migs.Extensions.StringBuilders
{
    /// <summary>
    /// Contains extension methods for StringBuilder.
    /// </summary>
    public static class StringBuilderExt
    {
        /// <summary>
        /// Clears the content of the StringBuilder.
        /// </summary>
        /// <param name="source"></param>
        public static void Clear(this StringBuilder source) => source.Length = 0;

        /// <summary>
        /// Appends the given arguments as new line considering the specified format
        /// </summary>
        /// <param name="source"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        public static StringBuilder AppendLine(this StringBuilder source, string format, params object[] args) 
			=> source.AppendLine(string.Format(format, args));

        /// <summary>
        /// Appends the given arguments considering the specified format
        /// </summary>
        /// <param name="source"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        public static StringBuilder Append(this StringBuilder source, string format, params object[] args) 
			=> source.Append(string.Format(format, args));

        /// <summary>
        /// Appends the given value if the condition is true.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="condition"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StringBuilder AppendIf(this StringBuilder source, bool condition, string value) 
            => condition ? source.Append(value) : source;

        /// <summary>
        /// Appends the given value as new line if the condition is true.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="condition"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StringBuilder AppendLineIf(this StringBuilder source, bool condition, string value) 
            => condition ? source.AppendLine(value) : source;

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
    }
}
