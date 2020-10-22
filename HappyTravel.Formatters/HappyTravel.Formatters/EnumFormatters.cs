using System;
using HappyTravel.Formatters.Extensions;

namespace HappyTravel.Formatters
{
    public static class EnumFormatters
    {
        public static string FromDescription<T>(T value) where T : Enum => EnumExtensions.ToDescriptionString(value);
    }
}