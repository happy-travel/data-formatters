using System.Collections.Generic;
using HappyTravel.Formatters.Enums;

namespace HappyTravel.Formatters.Extensions
{
    public static class CurrencyExtensions
    {
        public static int GetDecimalDigitsCount(this Currencies currency) => CurrencyDecimalDigits[currency];


        private static readonly Dictionary<Currencies, int> CurrencyDecimalDigits = new Dictionary<Currencies, int>
        {
            {Currencies.AED, 2},
            {Currencies.EUR, 2},
            {Currencies.SAR, 2},
            {Currencies.USD, 2}
        };
    }
}