using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Figure(new Point(10,2), new Point(6,6), new Point(8,0));
            Console.WriteLine($"The name of figure is {triangle.Name}");
            triangle.PerimeterCalculator();

            Figure square = new Figure(new Point(-2, 4), new Point(2, 4), new Point(2, 0), new Point(-2, 0));
            Console.WriteLine($"The name of figure is {square.Name}");
            square.PerimeterCalculator();

            Figure pentagon = new Figure(new Point(-4, 4), new Point(6, 8), new Point(8, 4), new Point(4, 2), new Point(-2, 2));
            Console.WriteLine($"The name of figure is {pentagon.Name}");
            pentagon.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
