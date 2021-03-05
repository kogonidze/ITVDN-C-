using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleAboutStore
{
    class Store
    {
        private Article[] articles;

        public Store()
        {
            articles = new Article[3];
            articles[0] = new Article("Evroopt", "bananas", 3.99);
            articles[1] = new Article("Korona", "cigarettes", 3.5);
            articles[2] = new Article("Sosedi", "sausages", 4.99);
        }

        public string this[int index]
        {
            get
            {
                if (index < articles.Length - 1)
                {
                    return $"Shopname: {articles[index].ShopName} Product: " +
                        $"{articles[index].ProductName} Cost: {articles[index].CostOfProduct}";
                }

                return "You are trying to go beyound the bounds of the array!";
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
                        return $"Shopname: {articles[i].ShopName} Product: " +
                            $"{articles[i].ProductName} Cost: {articles[i].CostOfProduct}";
                    }
                }

                return "There is no such product in our shop!";
            }
        }
    }
}
