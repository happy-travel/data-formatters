namespace HappyTravel.Formatters
{
    public static class EmailContentFormatters
    {
        public static string FromPassengerName(string firstName, string lastName, string? title = null)
        {
            var maskedName = firstName.Length == 1 ? "*" : firstName.Substring(0, 1);

            return title is null
                ? $"{maskedName}. {lastName}"
                : $"{title}. {maskedName} {lastName}";
        }
    }
}