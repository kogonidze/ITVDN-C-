namespace StoreApp;

internal class Store
{
    private Article[] articles;

    public Store()
    {
        InitializeArticles();
    }

    private void InitializeArticles()
    {
        articles = new Article[5];
        articles[0] = new Article("Milk", "Krama 24/7", 2);
        articles[1] = new Article("Bananas", "Krama 24/7", 4);
        articles[2] = new Article("Chicken fillet", "Agrokombinat", 13);
        articles[3] = new Article("Washing powder", "Hozmagazin", 40);
        articles[4] = new Article("Jeans", "Clothes shop", 100);
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < articles.Length)
                return articles[index].GetProductInfo();
            else
                return "Попытка обращения за пределы массива";
        }
    }

    public string this[string index]
    {
        get
        {
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].ProductName == index)
                {
                    return articles[i].GetProductInfo();
                }
            }

            return $"Продукт с названием {index} не найден!";
        }
    }
}
