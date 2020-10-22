using System;

namespace HappyTravel.Formatters
{
    public static class DateTimeFormatters
    {
        public static string ToUtcString(DateTime dateTime) => $"{dateTime:yyyy.MM.dd hh:mm} UTC";


        public static string ToDateString(DateTime? dateTime) => dateTime.HasValue ? dateTime.Value.ToString("dd-MMM-yy") : string.Empty;
    }
}