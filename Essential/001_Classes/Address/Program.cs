using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = "230025";
            address.Country = "Belarus";
            address.City = "Hrodna";
            address.Street = "Lenina";
            address.House = "6";

            Console.WriteLine($"Index: {address.Index}");
            Console.WriteLine($"Country: {address.Country}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"Street: {address.Street}");
            Console.WriteLine($"House: {address.House}");
            Console.WriteLine($"Apartment: {address.Apartment}");
        }
    }
}
