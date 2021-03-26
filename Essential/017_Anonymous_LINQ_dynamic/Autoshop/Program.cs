using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var Automall = new Autoshop();

            var info = from car in Automall.cars
                       join customer in Automall.customers on car.Model equals customer.Model
                       select new { car.Model, car.YearOfProduction, car.Make, car.Color,
                       customer.Name, customer.PhoneNumber};

            foreach (var item in info)
            {
                Console.WriteLine($"Customer name: {item.Name}, phone number: {item.PhoneNumber}");
                Console.WriteLine($"Make: {item.Make} Model: {item.Model} Year: {item.YearOfProduction} Color: {item.Color}");
                Console.WriteLine(new string('-', 50));
            }

            Console.ReadKey();
        }
    }
}
