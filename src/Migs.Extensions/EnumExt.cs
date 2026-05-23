using System.ComponentModel;
using System.Globalization;

namespace Migs.Extensions
{
    /// <summary>
    /// Contains extension methods for enums.
    /// </summary>
    public static class EnumExt
    {
        /// <summary>
        /// Descriptions the specified enum.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="enum">The enum.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">@enum must be an enum! - enum</exception>
        public static string Description<TEnum>(this TEnum @enum) where TEnum : IConvertible
        {
            if (@enum is not Enum)
                throw new ArgumentException("@enum must be an enum!", nameof(@enum));

            var description = "";
            var type = @enum.GetType();
            foreach (int value in Enum.GetValues(type))
            {
                if(value == @enum.ToInt32(CultureInfo.InvariantCulture))
                {
                    var enumName = type.GetEnumName(value);
                    if (enumName is null)
                        return "";
                    
                    var memberInfo = type.GetMember(enumName);
                    if(memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() is DescriptionAttribute attribute)
                    {
                        description = attribute.Description;
                        break;
                    }
                }
            }

            return description;
        }
    }
}
