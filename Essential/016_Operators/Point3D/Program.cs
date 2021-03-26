using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point(2.3, 4.2, 5.0);
            var point2 = new Point(1.7, 1.8, 2.0);

            Console.WriteLine(point1 + point2);
            Console.WriteLine(point1 - point2);
            Console.WriteLine(point1 * point2);
            Console.WriteLine(point1 / point2);

            Console.ReadKey();
        }
    }
}
