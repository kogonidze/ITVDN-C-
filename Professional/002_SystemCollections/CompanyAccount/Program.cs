using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, double>();

            dictionary.Add(1, 1000.2);
            dictionary.Add(2, 93322.4);
            dictionary.Add(3, 842141.2);

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }
            Console.WriteLine(new string('-', 50));


            var sortedList = new SortedList<int, double>();
            sortedList.Add(1, 343.4);
            sortedList.Add(2, 3242.5);
            sortedList.Add(3, 4242.1);

            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }
            Console.WriteLine(new string('-', 50));

            var sortedDictionary = new SortedDictionary<int, double>();
            sortedDictionary.Add(1, 2332.2);
            sortedDictionary.Add(2, 444.2);
            sortedDictionary.Add(3, 85385.1);
            var a = sortedList[1];

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();
        }
    }
}
