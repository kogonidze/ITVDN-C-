using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithMyDictionary;

namespace WorkWithNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new EngToRusDict();
            dict.Add("table", "стол");
            dict.Add("train", "поезд");

            Console.WriteLine(dict.Count);
            Console.WriteLine(dict.ShowValue("table"));

            Console.ReadKey();
        }
    }
}
