using CurrencyConverter;

var converter = new Converter(2.92, 3.19, 0.0364);

Console.WriteLine(converter.BuyBYN(30000, Currency.RUB));
Console.WriteLine(converter.BuyBYN(1000, Currency.EUR));

Console.WriteLine(converter.SoldBYN(1000, Currency.RUB));
Console.WriteLine(converter.SoldBYN(1000, Currency.USD));

Console.ReadKey();