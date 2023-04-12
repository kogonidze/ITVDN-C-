namespace InvoiceProject;

internal class Invoice
{
    private string article;
    private int quantity;

    public readonly int account;
    public readonly string customer;
    public readonly string provider;

    public string Article { get { return article; } set { article = value; } }
    public int Quantity { get { return quantity; } set { quantity = value; } }

    public Invoice(int account, string customer, string provider)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
    }

    public double CalculatePrice(bool includeNDS)
    {
        var price = CalculatePricePerUnit(Article) * Quantity;

        if (includeNDS) { return price += CalculateTaxFee(price); }

        return price;
    }

    private double CalculatePricePerUnit(string article)
        => article switch
        {
            "Laptop" => 1000,
            "Smartphone" => 500,
            "Headphones" => 100,
            _ => 0.0
        };

    private double CalculateTaxFee(double price)
    {
        double taxRate = 0.13;

        return price * taxRate;
    }
}
