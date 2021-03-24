using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict1 = new MyDictionary<string, string>();
            dict1.Add("Book", "Книга");
            dict1.Add("Train", "Поезд");
            dict1.Add("Car", "Автомобиль");

            Console.WriteLine(dict1[1]);
            Console.WriteLine(dict1["Train"]);

            foreach (var item in dict1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
    