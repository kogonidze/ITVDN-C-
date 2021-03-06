using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(5.2, 15.1));
            Console.WriteLine(Calculator.Substraction(15.2, 5.2));
            Console.WriteLine(Calculator.Multiplication(5, 4));
            Console.WriteLine(Calculator.Division(20, 2.5));
            Console.WriteLine(Calculator.Modulo(31.4, 19.2));

            Console.ReadKey();
        }
    }
}
