using System.Globalization;
using System.Net.Mail;
using System.Text;

namespace Smart.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns true if the given string is a Guid.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsGuid(this string source) => Guid.TryParse(source, out _);

        /// <summary>
        /// Indicates if the given string value is a valid mail address.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsMailAddress(this string source)
        {
            try
            {
                _ = new MailAddress(source);
                return true;
            }
            catch
            {
                return false;
            }            
        }

        /// <summary>
        /// Determines whether the given string is a date or not.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is date; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDate(this string value) => DateTime.TryParse(value, out _);

        /// <summary>
        /// Determines whether the given string is a valid Uri.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>
        ///   <c>true</c> if the given string is an absolute Uri; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsUri(this string source) => Uri.TryCreate(source, UriKind.Absolute, out _);

        /// <summary>
        /// Truncates the given string to the specified max length and appends the specified suffix.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="maxLength"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        public static string Truncate(this string source, int maxLength, string? suffix = "...")
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));

            if (source.Length == 0)
                return source;
            
            if (maxLength < 0 || maxLength > source.Length)
                return $"{source}{suffix}";

            return $"{source.Substring(0, maxLength).TrimEnd()}{suffix}";
        }
        
        /// <summary>
        /// Indicates whether the character at the specified is position is categorized as a decimal digit.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsDigit(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsDigit(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a Unicode letter.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsLetter(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsLetter(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a letter or decimal digit.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsLetterOrDigit(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsLetterOrDigit(source, index);

        /// <summary>
        /// Indicates whether the char object at the specified position is a high surrogate.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsHighSurrogate(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsHighSurrogate(source, index);

        /// <summary>
        /// Indicates whether the char object at the specified position is a low surrogate.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsLowSurrogate(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsLowSurrogate(source, index);

        
        /// <summary>
        /// Indicates whether the character at the specified position has a surrogate code unit.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsSurrogate(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsSurrogate(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a punctuation mark.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsPunctuation(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsPunctuation(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a separator character.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsSeparator(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsSeparator(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as an uppercase letter.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsUpper(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsUpper(source, index);

        /// <summary>
        /// Returns true if the given string is uppercase.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsUpper(this string source) => !string.IsNullOrEmpty(source) && source.ToUpperInvariant().Equals(source);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a lowercase letter.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsLower(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsLower(source, index);

        /// <summary>
        /// Returns true if the given string is uppercase.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsLower(this string source) => !string.IsNullOrEmpty(source) && source.ToLowerInvariant().Equals(source);
        
        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a white space.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsWhiteSpace(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsWhiteSpace(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a symbol character.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsSymbol(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsSymbol(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a control character.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsControl(this string source, int index) => !string.IsNullOrEmpty(source) && char.IsControl(source, index);

        /// <summary>
        /// Converts the given string into a byte array.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static byte[] ToByteArray(this string source, Encoding encoding)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));
            _ = encoding ?? throw new ArgumentNullException(nameof(encoding));
            
            return encoding.GetBytes(source);
        }

        /// <summary>
        /// Returns true if the given string is numeric.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string source) => !string.IsNullOrEmpty(source) && decimal.TryParse(source, out _);

        /// <summary>
        /// Converts the given string to the pascal case (upper camel case) convention.
        /// Returns a string containing letters and digits only, where each word starts with a capital letter.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <example>This is an example => ThisIsAnExample</example>
        public static string ToPascalCase(this string source)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));
            
            if (source.Length == 0)
                return source;

            var array = new char[source.Length];
            var pos = 0;
            var capitalize = true;
            foreach (var c in source)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (capitalize)
                        array[pos] = char.ToUpperInvariant(c);
                    else
                        array[pos] = char.ToLowerInvariant(c);

                    capitalize = false;
                    pos++;
                }
                else
                {
                    capitalize = true;
                }
            }

            return new string(array, 0, pos);
        }

        /// <summary>
        /// Converts the given string to the camel case convention.
        /// Returns a string containing letters and digits only, where each word starts with a capital letter.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <example>This is an example => thisIsAnExample</example>
        public static string ToCamelCase(this string source)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));
            
            if (source.Length == 0)
                return source;

            var array = new char[source.Length];
            var pos = 0;
            var capitalize = true;
            foreach (var c in source)
            {
                if (pos == 0)
                    array[pos] = char.ToLowerInvariant(c);
                
                if (char.IsLetterOrDigit(c))
                {
                    if (capitalize && pos > 0)
                        array[pos] = char.ToUpperInvariant(c);
                    else
                        array[pos] = char.ToLowerInvariant(c);

                    capitalize = false;
                    pos++;
                }
                else
                {
                    capitalize = true;
                }
            }

            return new string(array, 0, pos);
        }

        /// <summary>
        /// Removes all special characters of the given string.
        /// Returns a string only containing letters and digits.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string ToAlphaNumeric(this string source)
        {
            _ =  source ?? throw new ArgumentNullException(nameof(source));

            if (source.Length == 0)
                return source;
            
            var array = new char[source.Length];
            var pos = 0;
            foreach (var c in source.Where(char.IsLetterOrDigit))
            {
                array[pos] = c;
                pos++;
            }

            return new string(array, 0, pos);
        }

        /// <summary>
        /// Checks whether the provided string consists only of letters and numbers.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsAlphaNumeric(this string source) => !string.IsNullOrEmpty(source) && source.All(char.IsLetterOrDigit);
    }
}
