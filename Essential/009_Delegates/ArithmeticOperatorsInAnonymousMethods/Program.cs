using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperatorsInAnonymousMethods
{
    public delegate double ArithmeticDelegate(double x1, double x2);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value: ");
            var firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            var secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation: ");
            var arithmeticOp = Console.ReadLine();

            ArithmeticDelegate operation = null;
            switch (arithmeticOp)
            {
                case "+":
                    operation = (x1, x2) => x1 + x2;
                    break;
                case "-":
                    operation = (x1, x2) => x1 - x2;
                    break;
                case "*":
                    operation = (x1, x2) => x1 * x2;
                    break;
                case "/":
                    operation = (x1, x2) =>
                    {
                        if (x2 != 0)
                        {
                            return x1 / x2;
                        }

                        Console.WriteLine("You are trying to divide on zero!");
                        return 0;
                    };

                    break;
                default:
                    Console.WriteLine("You entered incorrect value of operation!");
                    break;
            }

            Console.WriteLine($"{operation(firstNum, secondNum)}");
            Console.ReadKey();
        }
    }
}
