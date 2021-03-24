using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        
        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }

    }
}
