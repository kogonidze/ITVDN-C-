using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithOrderedDictionary
{
    class Customer
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
            var secondCustomer = obj as Customer;

            return FirstName == secondCustomer.FirstName &&
                LastName == secondCustomer.LastName &&
                PassportID == secondCustomer.PassportID;
        }

        public override int GetHashCode()
        {
            return PassportID;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
