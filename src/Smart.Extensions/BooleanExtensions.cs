namespace Smart.Extensions;

/// <summary>
/// Contains extension methods for booleans
/// </summary>
public static class BooleanExtensions
{
    /// <summary>
    /// Converts the specified Boolean value to its integer representation (1 or 0).
    /// </summary>
    /// <param name="value">The Boolean value to convert.</param>
    /// <returns>1 if <paramref name="value"/> is <see langword="true"/>; otherwise, 0.</returns>
    public static int ToInt(this bool value) => value ? 1 : 0;
    
    /// <summary>
    /// Converts the specified Boolean value to its textual representation ("Yes" or "No").
    /// </summary>
    /// <param name="value">The Boolean value to convert.</param>
    /// <returns>"Yes" if <paramref name="value"/> is <see langword="true"/>; otherwise, "No".</returns>
    public static string ToYesNo(this bool value) => value ? "Yes" : "No";
}