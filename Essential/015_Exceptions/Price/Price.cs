using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    struct Price
    {
        public string ProductName { get; }

        public string ShopName { get; }

        public double ProductCost { get; set; }

        public Price(string productName, string shopName, double productCost)
        {
            ProductName = productName;
            ShopName = shopName;
            ProductCost = productCost;
        }
    }
}
