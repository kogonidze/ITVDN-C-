using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleAboutStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine(store[0]);
            Console.WriteLine(store["cigarettes"]);

            Console.WriteLine(store[6]);
            Console.WriteLine(store["oranges"]);

            Console.ReadKey();
        }
    }
}
