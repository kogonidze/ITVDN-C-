using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleAboutStore
{
    class Article
    {
        public string ShopName { get; }
        public string ProductName { get; }
        public double CostOfProduct { get; }

        public Article(string shopName, string productName, double costOfProduct)
        {
            ShopName = shopName;
            ProductName = productName;
            CostOfProduct = costOfProduct;
        }

    }
}
