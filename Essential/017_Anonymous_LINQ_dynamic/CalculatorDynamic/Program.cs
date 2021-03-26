using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1, 3));
            Console.WriteLine(Calculator.Add("hello", "world"));
            Console.WriteLine(Calculator.Add(4.5,3.2));

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(Calculator.Diff(7,5));
            Console.WriteLine(Calculator.Diff(4.5, 3.4));

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(Calculator.Multiply(7, 5));
            Console.WriteLine(Calculator.Multiply(4.5, 3.4));

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(Calculator.Division(7, 5));
            Console.WriteLine(Calculator.Division(4.5, 3.4));
            Console.WriteLine(Calculator.Division(4.5, 0));

            Console.ReadKey();
        }
    }
}
