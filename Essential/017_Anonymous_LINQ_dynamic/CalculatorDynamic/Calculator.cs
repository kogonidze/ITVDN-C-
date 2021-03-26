using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDynamic
{
    static class Calculator
    {
        public static dynamic Add(dynamic firstValue, dynamic secondValue)
        {
            return firstValue + secondValue;
        }

        public static dynamic Diff(dynamic firstValue, dynamic secondValue)
        {
            return firstValue - secondValue;
        }

        public static dynamic Multiply(dynamic firstValue, dynamic secondValue)
        {
            return firstValue * secondValue;
        }

        public static dynamic Division(dynamic firstValue, dynamic secondValue)
        {
            if (secondValue == 0)
            {
                return "Divide by zero error";
            }

            return firstValue / secondValue;
        }
    }
}
