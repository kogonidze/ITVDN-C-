using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class Calculator
    {
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Substraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double Modulo(double num1, double num2)
        {
            return num1 % num2;
        }
    }
}
