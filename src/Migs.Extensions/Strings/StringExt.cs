using System.Net.Mail;

namespace Migs.Extensions.Strings
{
    public static class StringExt
    {
        /// <summary>
        /// Returns true if the given string is a Guid.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsGuid(this string source) => Guid.TryParse(source, out Guid _);

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
            catch (Exception)
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
        public static bool IsDate(this string value) => DateTime.TryParse(value, out var _);

        
        /// <summary>
        /// Determines whether the given string is a valid Uri.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="uriKind">Kind of the URI.</param>
        /// <returns>
        ///   <c>true</c> if the specified URI kind is URI; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">source</exception>
        public static bool IsUri(this string source, UriKind uriKind = UriKind.Absolute)
        {
            _ = source ?? throw new ArgumentNullException(nameof(source));

            return Uri.TryCreate(source, uriKind, out var uriResult) 
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        /// <summary>
        /// Truncates the given string to the specified max length and appends the specified suffix.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="maxLength"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        public static string Truncate(this string source, int maxLength, string? suffix = "...")
        {
            suffix ??= "";

            if (string.IsNullOrEmpty(source))
                return suffix;
            else if (maxLength < 0 || maxLength > source.Length)
                return $"{source}{suffix}";
            else
                return $"{source[..maxLength].TrimEnd()}{suffix}";
        }

        /// <summary>
        /// Indicates whether the character at the specified is position is categorized as a decimal digit.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsDigit(this string source, int index) => char.IsDigit(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a Unicode letter.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsLetter(this string source, int index) => char.IsLetter(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a letter or decimal digit.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsLetterOrDigit(this string source, int index) => char.IsLetterOrDigit(source, index);

        /// <summary>
        /// Indicates whether the char object at the specified position is a high surrogate.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsHighSurrogate(this string source, int index) => char.IsHighSurrogate(source, index);

        /// <summary>
        /// Indicates whether the char object at the specified position is a low surrogate.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsLowSurrogate(this string source, int index) => char.IsLowSurrogate(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a control character.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsControl(this string source, int index) => char.IsControl(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a punctuation mark.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsPunctuation(this string source, int index) => char.IsPunctuation(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a separator character.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsSeparator(this string source, int index) => char.IsSeparator(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position has a surrogate code unit.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsSurrogate(this string source, int index) => char.IsSurrogate(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as an uppercase letter.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsUpper(this string source, int index) => char.IsUpper(source, index);

        /// <summary>
        /// Returns true if the given string is uppercase.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsUpper(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            return s.ToUpper().Equals(s);
        }

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a lowercase letter.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsLower(this string source, int index) => char.IsLower(source, index);

        /// <summary>
        /// Returns true if the given string is uppercase.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsLower(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            return s.ToLower().Equals(s);
        }

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a white space.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsWhiteSpace(this string source, int index) => char.IsWhiteSpace(source, index);

        /// <summary>
        /// Indicates whether the character at the specified position is categorized as a symbol character.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool IsSymbol(this string source, int index) => char.IsSymbol(source, index);

        /// <summary>
        /// Converts the given string into a byte array.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string value) => new byte[value.Length];

        /// <summary>
        /// Returns true if the given string is numeric.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string value) => int.TryParse(value, out _);

        /// <summary>
        /// Converts the given string to the camel case convention.
        /// Returns a string containing letters and digits only, where each word starts with a capital letter.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <example>This is an example => ThisIsAnExample</example>
        public static string ToCamelCase(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            char[] array = new char[value.Length];
            int pos = 0;
            bool capitalize = true;
            foreach (var c in value)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (capitalize)
                        array[pos] = char.ToUpper(c);
                    else
                        array[pos] = char.ToLower(c);

                    capitalize = false;
                    pos++;
                }
                else if(char.IsWhiteSpace(c))
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
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToAlphaNumeric(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            char[] array = new char[value.Length];
            int pos = 0;
            foreach (var c in value)
            {
                if (char.IsLetterOrDigit(c))
                {
                    array[pos] = c;
                    pos++;
                }
            }

            return new string(array, 0, pos);
        }

        /// <summary>
        /// Removes all special characters of the given string.
        /// Returns a string only container letters and digits.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsAlphaNumeric(this string? value)
        {
            if (value is null)
                return false;

            foreach (var c in value)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }

            return true;
        }
    }
}
