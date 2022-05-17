using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace SilkFloAnalytic
{
    public static class Services
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                       .GetMember(enumValue.ToString())
                       .First()
                       .GetCustomAttribute<DescriptionAttribute>()?
                       .Description ?? enumValue.ToString();
        }
    }
}
