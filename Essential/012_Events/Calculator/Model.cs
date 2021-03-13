using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Model
    {
        public double GetArithmeticResult(int firstValue, int secondValue, Operations op)
        {
            switch (op)
            {   
                case Operations.Add:
                    return firstValue + secondValue;
                case Operations.Difference:
                    return firstValue - secondValue;
                case Operations.Multiplication:
                    return firstValue * secondValue;
                case Operations.Division:
                    return (double)firstValue / secondValue;
                default:
                    return default(double);
            }
        }
    }
}
