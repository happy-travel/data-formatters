using System;
using HappyTravel.Formatters.Extensions;

namespace HappyTravel.Formatters
{
    public static class EnumFormatters
    {
        public static string FromEnumDescription<T>(T value) where T : Enum => EnumExtensions.ToDescriptionString(value);
    }
}