using System;

namespace lab3.Task3
{
    class Program
    {
        static void Main()
        {
            // задаём курсы
            CurrencyUSD.RateToEUR = 0.93m;
            CurrencyUSD.RateToRUB = 92m;

            var usd = new CurrencyUSD(100);
            CurrencyEUR eur = usd; // неявно
            CurrencyRUB rub = eur; // неявно
            Console.WriteLine($"{usd.Value} USD = {eur.Value:F2} EUR = {rub.Value:F2} RUB");
        }
    }
}