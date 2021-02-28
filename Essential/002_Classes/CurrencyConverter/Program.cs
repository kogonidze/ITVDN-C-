using System;
using Shared;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new Converter(2.60, 3.02, 3.35);

            Menu.StartWork(Constants.MenuText,
                () => converter.Convert(Currency.USD, false),
                () => converter.Convert(Currency.EUR, false),
                () => converter.Convert(Currency.RUB, false),
                () => converter.Convert(Currency.USD, true),
                () => converter.Convert(Currency.EUR, true),
                () => converter.Convert(Currency.RUB, true),
                () => Environment.Exit(0));
        }
    }
}
