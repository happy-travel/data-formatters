using System;
using HappyTravel.Formatters.Enums;
using HappyTravel.Formatters.Extensions;
using HappyTravel.Formatters.Models;

namespace HappyTravel.Formatters
{
    public static class MoneyRounder
    {
        public static MoneyAmount Ceil(MoneyAmount moneyAmount) => new MoneyAmount(Ceil(moneyAmount.Amount, moneyAmount.Currency), moneyAmount.Currency);


        public static decimal Ceil(decimal target, string currency) => Ceil(target, Enum.Parse<Currencies>(currency));


        public static decimal Ceil(decimal target, Currencies currency) => Math.Round(target, currency.GetDecimalDigitsCount(), MidpointRounding.AwayFromZero);


        public static MoneyAmount Truncate(MoneyAmount moneyAmount)
            => new MoneyAmount(Truncate(moneyAmount.Amount, moneyAmount.Currency), moneyAmount.Currency);


        public static decimal Truncate(decimal target, string currency) => Truncate(target, Enum.Parse<Currencies>(currency));


        public static decimal Truncate(decimal target, Currencies currency) => Math.Round(target, currency.GetDecimalDigitsCount(), MidpointRounding.ToZero);
    }
}