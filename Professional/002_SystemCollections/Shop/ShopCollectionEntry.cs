using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ShopCollectionEntry
    {
        public Customer Customer { get; }
        public ProductCategory ProductCategory { get; }

        public ShopCollectionEntry(Customer customer, ProductCategory productCategory)
        {
            Customer = customer;
            ProductCategory = productCategory;
        }
    }
}
