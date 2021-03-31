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
            orderedDict.Add(new Customer("Viktor", "Viktorov", 2), 3);

            Console.WriteLine(orderedDict.Contains(new Customer("Viktor", "Viktorov", 2)));

            Console.ReadKey();
        }
    }
}
