namespace CurrencyConverter;

internal class Converter
{
    private double usd;
    private double eur;
    private double rub;

    public Converter(double usd, double eur, double rub)
    {
        this.usd = usd;
        this.eur = eur;
        this.rub = rub;
    }

    public double SoldBYN(double amount, Currency target)
    {
        return target switch
        {
            Currency.USD => amount / usd,
            Currency.EUR => amount / eur,
            Currency.RUB => amount / rub,
            _ => throw new InvalidOperationException("Not supported target currency!"),
        };
    }

    public double BuyBYN(double amount, Currency source) 
    {
        return source switch
        {
            Currency.USD => amount * usd,
            Currency.EUR => amount * eur,
            Currency.RUB => amount * rub,
            _ => throw new InvalidOperationException("Not supported source currency!"),
        };
    }
}
