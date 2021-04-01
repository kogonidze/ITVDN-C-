using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ShopCollection
    {
        public ShopCollectionEntry[] Entries { get; set; }

        public ShopCollection()
        {
            Entries = new ShopCollectionEntry[0];
        }

        public int Count => Entries.Length;

        public int Add(ShopCollectionEntry newEntry)
        {
            var newItems = new ShopCollectionEntry[Count + 1];
            Array.Copy(Entries, newItems, Count);
            newItems[Count] = newEntry;

            Entries = newItems;
            return Count;
        }

        public ProductCategory[] FindCategoriesByCustomer(Customer customer)
        {
            var categories = new List<ProductCategory>();

            foreach (var entry in Entries)
            {
                if (entry.Customer.Equals(customer))
                {
                    categories.Add(entry.ProductCategory);
                }
            }

            return categories.ToArray();
        }

        public Customer[] FindCustomerByCategory(ProductCategory category)
        {
            var customers = new List<Customer>();

            foreach (var entry in Entries)
            {
                if (entry.ProductCategory.Equals(category))
                {
                    customers.Add(entry.Customer);
                }
            }

            return customers.ToArray();
        }
    }
}
