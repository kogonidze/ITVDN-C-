using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAnonymousFunc
{
    class Program
    {
        public delegate double AverageDelegate(int x1, int x2, int x3);

        static void Main(string[] args)
        {
            AverageDelegate avgFullSyntax = new AverageDelegate(delegate (int x1, int x2, int x3) { return (x1 + x2 + x3) / 3.0; });
            AverageDelegate avgShortSyntax = delegate (int x1, int x2, int x3) { return (x1 + x2 + x3) / 3.0; };
            AverageDelegate avgLambdaExpression = (int x1, int x2, int x3) => (x1 + x2 + x3) / 3.0;

            Console.WriteLine(avgLambdaExpression(5,2,2));
            Console.WriteLine(avgShortSyntax(5,2,2));
            Console.WriteLine(avgFullSyntax(5,2,2));

            Console.ReadKey();
        }
    }
}
