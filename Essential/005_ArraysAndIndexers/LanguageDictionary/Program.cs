using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary["sun"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["кнiга"]);

            Console.WriteLine(dictionary["муравей"]);
            Console.WriteLine(dictionary[10]);

            Console.ReadKey();
        }
    }
}
