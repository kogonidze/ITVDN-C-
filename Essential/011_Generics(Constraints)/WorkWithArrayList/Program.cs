using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add("First string");
            list.Add("Second string");
            list.Add(new Object());
            list.Add(1);
            list.Add(2);
            list.Add(2.5);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }
    }
}
