using System;

namespace HappyTravel.Formatters
{
    public static class DateTimeFormatters
    {
        public static string FromDateTime(DateTime dateTime) => $"{dateTime:yyyy.MM.dd hh:mm} UTC";
    }
}