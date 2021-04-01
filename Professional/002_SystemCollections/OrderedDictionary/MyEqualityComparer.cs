using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithOrderedDictionary
{
    class MyEqualityComparer : IEqualityComparer
    {
        public new bool Equals(object first, object second)
        {
            var firstCustomer = first as Customer;
            var secondCustomer = second as Customer;

            return firstCustomer.FirstName == secondCustomer.FirstName &&
                firstCustomer.LastName == secondCustomer.LastName &&
                firstCustomer.PassportID == secondCustomer.PassportID;
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
    }
}
