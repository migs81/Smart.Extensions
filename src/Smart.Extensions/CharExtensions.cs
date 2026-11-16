using System.Globalization;

namespace Smart.Extensions
{
    /// <summary>
    /// Contains extension methods for characters
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        /// Converts the specified character to its uppercase equivalent.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>The uppercase equivalent of <paramref name="c"/>.</returns>
        public static char ToUpper(this char c) => char.ToUpper(c);

        /// <summary>
        /// Converts the specified character to its uppercase equivalent using the specified culture.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <param name="culture">The culture to use for the conversion.</param>
        /// <returns>The uppercase equivalent of <paramref name="c"/>.</returns>
        public static char ToUpper(this char c, CultureInfo culture) => char.ToUpper(c, culture);

        /// <summary>
        /// Converts the specified character to its uppercase equivalent using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns></returns>
        public static char ToUpperInvariant(this char c) => char.ToUpperInvariant(c);

        /// <summary>
        /// Converts the specified character to its lowercase equivalent.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>The lowercase equivalent of <paramref name="c"/>.</returns>
        public static char ToLower(this char c) => char.ToLower(c);

        /// <summary>
        /// Converts the specified character to its lowercase equivalent using the specified culture.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <param name="culture">The culture to use for the conversion.</param>
        /// <returns>The lowercase equivalent of <paramref name="c"/>.</returns>
        public static char ToLower(this char c, CultureInfo culture) => char.ToLower(c, culture);

        /// <summary>
        /// Converts the specified character to its lowercase equivalent using invariant culture.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>The lowercase equivalent of <paramref name="c"/>.</returns>
        public static char ToLowerInvariant(this char c) => char.ToLowerInvariant(c);

        /// <summary>
        /// Determines whether this instance is digit.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is digit; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDigit(this char c) => char.IsDigit(c);

        /// <summary>
        /// Determines whether this instance is letter.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is letter; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLetter(this char c) => char.IsLetter(c);

        /// <summary>
        /// Determines whether [is letter or digit].
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if [is letter or digit] [the specified c]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLetterOrDigit(this char c) => char.IsLetterOrDigit(c);

        /// <summary>
        /// Determines whether [is high surrogate].
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if [is high surrogate] [the specified c]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsHighSurrogate(this char c) => char.IsHighSurrogate(c);

        /// <summary>
        /// Determines whether [is low surrogate].
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if [is low surrogate] [the specified c]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLowSurrogate(this char c) => char.IsLowSurrogate(c);

        /// <summary>
        /// Determines whether this instance is control.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is control; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsControl(this char c) => char.IsControl(c);

        /// <summary>
        /// Determines whether this instance is punctuation.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is punctuation; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPunctuation(this char c) => char.IsPunctuation(c);

        /// <summary>
        /// Determines whether this instance is separator.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is separator; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsSeparator(this char c) => char.IsSeparator(c);

        /// <summary>
        /// Determines whether this instance is surrogate.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is surrogate; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsSurrogate(this char c) => char.IsSurrogate(c);

        /// <summary>
        /// Determines whether this instance is upper.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is upper; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsUpper(this char c) => char.IsUpper(c);

        /// <summary>
        /// Determines whether this instance is lower.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is lower; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLower(this char c) => char.IsLower(c);

        /// <summary>
        /// Determines whether [is white space].
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if [is white space] [the specified c]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWhiteSpace(this char c) => char.IsWhiteSpace(c);

        /// <summary>
        /// Determines whether this instance is symbol.
        /// </summary>
        /// <param name="c">The character to convert.</param>
        /// <returns>
        ///   <c>true</c> if the specified c is symbol; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsSymbol(this char c) => char.IsSymbol(c);
    }
}
