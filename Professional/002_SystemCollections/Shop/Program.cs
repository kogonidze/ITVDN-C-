using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopList = new ShopCollection();

            shopList.Add(new ShopCollectionEntry(new Customer("Ivan", "Ivanov", 1), ProductCategory.Alcohol));
            shopList.Add(new ShopCollectionEntry(new Customer("Aleksey", "Alekseev", 2), ProductCategory.Cereals));
            shopList.Add(new ShopCollectionEntry(new Customer("Alexandr", "Popov", 3), ProductCategory.Meat));
            shopList.Add(new ShopCollectionEntry(new Customer("Vasili", "Syrnikov", 4), ProductCategory.Alcohol));
            shopList.Add(new ShopCollectionEntry(new Customer("Igor", "Kivinov", 5), ProductCategory.Alcohol));

            var categories1 = shopList.FindCategoriesByCustomer(new Customer("Alexandr", "Popov", 3));

            foreach (var item in categories1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 50));

            var customers = shopList.FindCustomerByCategory(ProductCategory.Alcohol);

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
