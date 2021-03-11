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
            var engToRus = new MyDictionary<string, string>();

            engToRus.Add("Book", "Книга");
            engToRus.Add("Train", "Поезд");
            engToRus.Add("Car", "Машина");

            Console.WriteLine(engToRus.Count);
            Console.WriteLine(engToRus[2]);

            Console.ReadKey();
        }
    }
}
