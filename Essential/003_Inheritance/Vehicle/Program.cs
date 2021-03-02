using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship Titanic = new Ship(1000000, 100, 50000, "Birmngham");
            Console.WriteLine($"Titanic coordinates: {Titanic.CoordX}:{Titanic.CoordY}");
            Console.WriteLine($"Titanic production year: {Titanic.ProductionYear}");
            Console.WriteLine($"Titanic home port: {Titanic.HomePort}");

            Console.WriteLine(new string('-', 50));

            Ship Olympic = new Ship(5.0, 3.0, 500000, 50.0, 1915, 50000, "London");
            Console.WriteLine($"Olympic coordinates: {Olympic.CoordX}:{Olympic.CoordY}");
            Console.WriteLine($"Olympic production year: {Olympic.ProductionYear}");
            Console.WriteLine($"Olympic home port: {Olympic.HomePort}");

            Console.WriteLine(new string('-', 50));

            Car Audi = new Car(20000, 180);
            Console.WriteLine($"Audi coordinates: {Audi.CoordX}:{Audi.CoordY}");
            Console.WriteLine($"Audi production year: {Audi.ProductionYear}");
            Console.WriteLine($"Audi price: {Audi.Price}");

            Console.WriteLine(new string('-', 50));

            Plane IL26 = new Plane(150.5, 34.0, 100000000, 950.0, 1976, 410.0, 2);
            Console.WriteLine($"IL26 coordinates: {IL26.CoordX}:{IL26.CoordY}");
            Console.WriteLine($"IL26 production year: {IL26.ProductionYear}");
            Console.WriteLine($"IL26 number of passengers: {IL26.NumberOfPassengers}");

            Console.ReadKey();
        }
    }
}
