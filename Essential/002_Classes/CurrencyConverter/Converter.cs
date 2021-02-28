using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    enum Currency
    {
        USD,
        EUR,
        RUB,
    }
    class Converter
    {
        public double USD { get; set; }
        public double EUR { get; set; }
        public double RUB { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double GetCurrencyRate(Currency currency)
        {
            switch (currency)
            {
                case Currency.USD:
                    return USD;
                case Currency.EUR:
                    return EUR;
                case Currency.RUB:
                    return RUB;
            }

            return 0.0;
        }
        public void Convert(Currency currency, bool isConvertToUAH)
        {
            Console.WriteLine("Enter the amount of money: ");

            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                var currencyRate = GetCurrencyRate(currency);

                if (isConvertToUAH)
                {
                    Console.WriteLine($"Now you have {amount * currencyRate} UAH");
                }
                else
                {
                    Console.WriteLine($"Now you have {amount / currencyRate} {currency}");
                }
            }
            else
            {
                Console.WriteLine("You entered incorrect value");
            } 
        }
    }
}
