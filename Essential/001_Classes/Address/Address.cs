using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        private void InitializeAddress()
        {
            index = "";
            country = "";
            city = "";
            street = "";
            house = "";
            apartment = "";
        }
        public Address()
        {
            InitializeAddress();
        }
        public string Index
        {
            get
            {
                if (index != "")
                {
                    return index;
                }
                else
                {
                    return "Field Index is empty";
                }
            }
            set
            {
                if (value != "Foo")
                {
                    index = value;
                }
            }
        }

        public string Country
        {
            get
            {
                if (country != "")
                {
                    return country;
                }
                else
                {
                    return "Field Country is empty";
                }
            }
            set
            {
                if (value != "China")
                {
                    country = value;
                }
            }
        }

        public string City
        {
            get
            {
                if (city != "")
                {
                    return city;
                }
                else
                {
                    return "Field City is empty";
                }
            }
            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                if (street != "")
                {
                    return street;
                }
                else
                {
                    return "Field Street is empty";
                }
            }
            set
            {
                street = value;
            }
        }

        public string House
        {
            get
            {
                if (house != "")
                {
                    return house;
                }
                else
                {
                    return "Field House is empty";
                }
            }
            set
            {
                house = value;
            }
        }

        public string Apartment
        {
            get
            {
                if (apartment != "")
                {
                    return apartment;
                }
                else
                {
                    return "Field Apartment is empty";
                }
            }
            set
            {
                apartment = value;
            }
        }
    }
}
