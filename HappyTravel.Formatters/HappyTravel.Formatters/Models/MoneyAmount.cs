using HappyTravel.Formatters.Enums;

namespace HappyTravel.Formatters.Models
{
    public readonly struct MoneyAmount
    {
        public MoneyAmount(decimal amount, Currencies currency)
        {
            Amount = amount;
            Currency = currency;
        }


        public void Deconstruct(out decimal amount, out Currencies currency)
        {
            amount = Amount;
            currency = Currency;
        }


        public decimal Amount { get; }
        public Currencies Currency { get; }
    }
}