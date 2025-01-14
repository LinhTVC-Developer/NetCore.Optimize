using System.ComponentModel;
using System.Reflection;

namespace NetCore.Libraries.Extensions
{
    public static class EnumExtensions
    {
        public static string EnumDescription(this Enum value)
        {
            if(value == null)
            {
                return "";
            }
            FieldInfo fieldInfo = value?.GetType().GetField(value?.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes != null && attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }
    }
}
