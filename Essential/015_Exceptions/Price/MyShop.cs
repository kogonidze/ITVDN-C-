using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    class MyBasket
    {
        private Price[] products;

        public MyBasket()
        {
            products = new Price[2];
        }

        public void AddProducts()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter the product name: ");
                var productName = Console.ReadLine();

                Console.WriteLine("Enter the shopName: ");
                var shopName = Console.ReadLine();

                Console.WriteLine("Enter the price");
                var price = Convert.ToDouble(Console.ReadLine());

                Console.Clear();
                products[i] = new Price(productName, shopName, price);
            }

            products = products.OrderBy(product => product.ShopName).ToArray();
        }

        public string this[string shopName]
        {
            get
            {
                var productInfo = "";

                foreach (var product in products)
                {
                    if (product.ShopName == shopName)
                    {
                        productInfo += $"Product name: {product.ProductName} Cost: {product.ProductCost} \n";
                    }
                }

                if (productInfo == "")
                {
                    throw new ShopNotFoundException();
                }

                return productInfo;
            }
        }
    }
}
