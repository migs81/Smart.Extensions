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
}