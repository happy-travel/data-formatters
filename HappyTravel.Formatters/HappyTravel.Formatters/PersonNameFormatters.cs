namespace HappyTravel.Formatters
{
    public static class PersonNameFormatters
    {
        public static string ToMaskedName(string firstName, string lastName, string? title = null)
        {
            var mask = firstName.Length == 1 ? "*" : firstName.Substring(0, 1);

            return title is null
                ? $"{mask}. {lastName}"
                : $"{title}. {mask} {lastName}";
        }
    }
}