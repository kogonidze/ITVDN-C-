using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    class ShopNotFoundException : Exception
    {
        public ShopNotFoundException()
            : base("There is no products from such shop!")
        {

        }
    }
}
