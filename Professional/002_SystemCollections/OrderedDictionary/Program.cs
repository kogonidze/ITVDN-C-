using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithOrderedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderedDict = new OrderedDictionary(new MyEqualityComparer());

            orderedDict.Add(new Customer("Ivan", "Popov", 1), 1);
            orderedDict.Add(new Customer("Viktor", "Viktorov", 2), 2);
            try
            {
                orderedDict.Add(new Customer("Viktor", "Viktorov", 2), 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            

            Console.WriteLine(orderedDict.Contains(new Customer("Viktor", "Viktorov", 2)));

            foreach (var item in orderedDict.Keys)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
