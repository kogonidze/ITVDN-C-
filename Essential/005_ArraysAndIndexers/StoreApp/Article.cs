namespace StoreApp;

internal class Article
{
    private string productName;
    private string shopName;
    private decimal productCostInByn;

    public Article(
        string productName,
        string shopName,
        decimal productCostInByn)
    {
        this.productName = productName;
        this.shopName = shopName;
        this.productCostInByn = productCostInByn;
    }

    public string ProductName {  get { return productName; } }

    public string GetProductInfo()
        => $"Product name: {productName}, shopName: {shopName}," +
        $"cost of product (BYN): {productCostInByn}";
}
