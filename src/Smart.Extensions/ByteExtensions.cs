using System.Security.Cryptography;
using System.Text;

namespace Smart.Extensions;

public static class ByteExtensions
{
    /// <summary>
    /// Converts the specified byte array to an uppercase hexadecimal string.
    /// </summary>
    /// <param name="bytes">The byte array to convert.</param>
    /// <returns>The hexadecimal representation of the specified byte array.</returns>
    public static string ToHexString(this byte[] bytes)
    {
        if (bytes is null)
            throw new ArgumentNullException(nameof(bytes));
        
        var sb = new StringBuilder();
        foreach (var i in bytes)
            sb.Append(i.ToString("X2"));
        
        return sb.ToString();
    }
    
    /// <summary>
    /// Computes the MD5 hash of the specified byte array.
    /// </summary>
    /// <param name="value">The byte array to compute the hash for.</param>
    /// <returns>The MD5 hash as an uppercase hexadecimal string.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <see langword="null"/>.</exception>
    public static string GetMd5Hash(this byte[] value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        using var md5 = MD5.Create();
        var bytes = md5.ComputeHash(value);
        return bytes.ToHexString();
    }
    
    /// <summary>
    /// Creates a <see cref="MemoryStream"/> from the specified byte array.
    /// </summary>
    /// <param name="bytes">The byte array to create the stream from.</param>
    /// <returns>A <see cref="MemoryStream"/> backed by the specified byte array.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="bytes"/> is <see langword="null"/>.</exception>
    public static Stream ToStream(this byte[] bytes)
    {
        if (bytes is null)
            throw new ArgumentNullException(nameof(bytes));
        
        return new MemoryStream(bytes);
    }
    
    /// <summary>
    /// Converts the specified byte array to a UTF-8 encoded string.
    /// </summary>
    /// <param name="bytes">The byte array to convert.</param>
    /// <returns>The UTF-8 decoded string.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="bytes"/> is <see langword="null"/>.</exception>
    public static string ToUtf8String(this byte[] bytes)
    {
        if (bytes is null)
            throw new ArgumentNullException(nameof(bytes));

        return Encoding.UTF8.GetString(bytes);
    }
    
    /// <summary>
    /// Converts the specified byte array to a string using the specified encoding.
    /// </summary>
    /// <param name="bytes">The byte array to convert.</param>
    /// <param name="encoding">The encoding to use for the conversion.</param>
    /// <returns>The decoded string.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="bytes"/> or <paramref name="encoding"/> is <see langword="null"/>.</exception>
    public static string ToEncodedString(this byte[] bytes, Encoding encoding)
    {
        if (bytes is null)
            throw new ArgumentNullException(nameof(bytes));

        if (encoding is null)
            throw new ArgumentNullException(nameof(encoding));

        return encoding.GetString(bytes);
    }
}