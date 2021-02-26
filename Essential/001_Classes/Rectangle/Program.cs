using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first length value of rectangle: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Enter the second length value of rectangle: ");
            var input2 = Console.ReadLine();

            if (int.TryParse(input1, out int length1) && int.TryParse(input2, out int length2))
            {
                Rectangle rectangle = new Rectangle(length1, length2);

                Console.WriteLine($"The area of the rectangle is {rectangle.Area}");
                Console.WriteLine($"The perimeter of the rectangle is {rectangle.Perimeter}");
            }
            else
            {
                Console.WriteLine("You entered incorrect data!");
            }

            Console.ReadKey();
        }
    }
}
