namespace lab3.Task3
{
    public class Currency
    {
        public decimal Value { get; protected set; }
        public Currency(decimal value) => Value = value;
    }

    public class CurrencyUSD : Currency
    {
        public static decimal RateToEUR { get; set; } = 0.95m;
        public static decimal RateToRUB { get; set; } = 90m;

        public CurrencyUSD(decimal value) : base(value) { }

        public static implicit operator CurrencyEUR(CurrencyUSD usd) =>
            new CurrencyEUR(usd.Value * RateToEUR);

        public static implicit operator CurrencyRUB(CurrencyUSD usd) =>
            new CurrencyRUB(usd.Value * RateToRUB);
    }

    public class CurrencyEUR : Currency
    {
        public static decimal RateToUSD { get; set; } = 1.05m;
        public static decimal RateToRUB { get; set; } = 95m;

        public CurrencyEUR(decimal value) : base(value) { }

        public static implicit operator CurrencyUSD(CurrencyEUR eur) =>
            new CurrencyUSD(eur.Value * RateToUSD);

        public static implicit operator CurrencyRUB(CurrencyEUR eur) =>
            new CurrencyRUB(eur.Value * RateToRUB);
    }

    public class CurrencyRUB : Currency
    {
        public static decimal RateToUSD { get; set; } = 0.011m;
        public static decimal RateToEUR { get; set; } = 0.010m;

        public CurrencyRUB(decimal value) : base(value) { }

        public static implicit operator CurrencyUSD(CurrencyRUB rub) =>
            new CurrencyUSD(rub.Value * RateToUSD);

        public static implicit operator CurrencyEUR(CurrencyRUB rub) =>
            new CurrencyEUR(rub.Value * RateToEUR);
    }
}