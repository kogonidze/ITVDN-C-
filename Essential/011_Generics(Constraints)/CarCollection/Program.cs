using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<BaseCar> commonGarage = new CarCollection<BaseCar>();
            commonGarage.Add(new Car("Toyota", 2012));
            commonGarage.Add(new Bus("Ikarus", 1984, 80));
            commonGarage.Add(new Truck("Volvo", 2010, 5000));

            Console.WriteLine(commonGarage[1]);
            Console.WriteLine(commonGarage.Count);

            commonGarage.Clear();
            Console.WriteLine(commonGarage.Count);

            Console.ReadKey();
        }
    }
}
