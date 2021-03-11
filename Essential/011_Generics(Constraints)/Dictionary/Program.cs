using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> engToRus = new Dictionary<string, string>();
            engToRus.Add("Book", "книга");
            engToRus.Add("Table", "стол");
            engToRus.Add("Bike", "велосипед");

            Console.WriteLine(engToRus.Count);
            Console.WriteLine(engToRus[1]);
            Console.WriteLine(engToRus["Table"]);
            Console.WriteLine(engToRus["SUN"]);
            Console.WriteLine(engToRus.Contains("Bike"));

            engToRus.Clear();

            Console.WriteLine(engToRus.Count);

            Console.ReadKey();
        }
    }
}
