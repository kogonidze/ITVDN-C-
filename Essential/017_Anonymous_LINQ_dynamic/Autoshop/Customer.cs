using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop
{
    class Customer
    {
        public string Name { get; }
        public string PhoneNumber { get; }
        public string Model { get; }

        public Customer(string name, string phoneNumber, string model)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Model = model;
        }
    }
}
