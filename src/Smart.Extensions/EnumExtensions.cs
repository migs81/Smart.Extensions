using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Smart.Extensions
{
    /// <summary>
    /// Contains extension methods for enums.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Retrieves the description of the specified enum value from its <see cref="DescriptionAttribute"/>.
        /// </summary>
        /// <typeparam name="TEnum">The enum type.</typeparam>
        /// <param name="enum">The enum value to retrieve the description from.</param>
        /// <returns>The description of the enum value, or an empty string if no description is defined.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="enum"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException"><paramref name="enum"/> is not an enum value.</exception>
        public static string GetDescription<TEnum>(this TEnum @enum) where TEnum : IConvertible
        {
            if (@enum is null)
                throw new ArgumentNullException(nameof(@enum));
            
            if (@enum is not Enum)
                throw new ArgumentException("@enum must be an enum!", nameof(@enum));
            
            // name
            var type = @enum.GetType();
            var enumName = Enum.GetName(type, @enum);
            if (enumName is null) return "";
            
            // description
            var memberInfo = type.GetMember(enumName)[0];
            var attribute = memberInfo.GetCustomAttribute(typeof(DescriptionAttribute), false);
            if (attribute is DescriptionAttribute descriptionAttribute)
                return descriptionAttribute.Description;

            return "";
        }

        /// <summary>
        /// Retrieves the name of the specified enum value.
        /// </summary>
        /// <typeparam name="TEnum">The enum type.</typeparam>
        /// <param name="enum">The enum value to retrieve the name from.</param>
        /// <returns>The name of the enum value, or an empty string if no name is defined.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="enum"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException"><paramref name="enum"/> is not an enum value.</exception>
        public static string GetName<TEnum>(this TEnum @enum) where TEnum : IConvertible
        {
            if (@enum is null)
                throw new ArgumentNullException(nameof(@enum));
            
            if (@enum is not Enum)
                throw new ArgumentException("@enum must be an enum!", nameof(@enum));

            var name = Enum.GetName(@enum.GetType(), @enum);
            return name ?? "";
        }
    }
}
