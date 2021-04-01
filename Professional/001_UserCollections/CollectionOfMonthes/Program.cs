using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfMonthes
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthCollection = new MonthCollection();
            Console.WriteLine(monthCollection.GetMonthByOrderNumber(1));
            Console.WriteLine(monthCollection.GetMonthByOrderNumber(5));

            Console.WriteLine(new string('-', 50));
            Console.WriteLine(monthCollection.GetMonthByNumberOfDays(31));

            Console.WriteLine(new string('-', 50));
            Console.WriteLine(monthCollection.GetMonthByNumberOfDays(30));

            Console.WriteLine(new string('-', 50));
            foreach (var month in monthCollection)
            {
                Console.WriteLine(month);
            }


            Console.ReadKey();
        }
    }
}
