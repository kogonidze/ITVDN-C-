using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(4);
            myList.Add(2);
            myList.Add(5);

            Console.WriteLine($"Count of elements: {myList.Count}");

            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

            MyList<MyCar> listOfCars = new MyList<MyCar>();
            listOfCars.Add(new MyCar("Audi", "A6", 2010));
            listOfCars.Add(new MyCar("BMW", "530e", 1998));
            listOfCars.Add(new MyCar("Dodge", "Caravan", 1998));

            Console.WriteLine($"Count of elements: {listOfCars.Count}");

            foreach (var item in listOfCars)
            {
                Console.WriteLine($"{item.Vendor} {item.Model} {item.YearOfProduction}");
            }

            Console.ReadKey();
        }
    }
}
