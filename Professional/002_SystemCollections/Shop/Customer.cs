using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PassportID { get; set; }

        public Customer(string firstName, string lastName, int passportID)
        {
            FirstName = firstName;
            LastName = lastName;
            PassportID = passportID;
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            return customer.FirstName == FirstName && 
                customer.LastName == LastName &&
                customer.PassportID == PassportID;
        }

        public override int GetHashCode()
        {
            return PassportID.GetHashCode();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
