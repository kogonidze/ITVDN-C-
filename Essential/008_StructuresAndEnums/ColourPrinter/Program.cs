using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourPrinter
{
    enum ColorSet
    {
        White,
        Red,
        Green,
        Yellow,
        Blue,
        Magenta
    }

    class Program
    {
        static void Print(string stroka, int color)
        {
            ColorSet colorEnum = (ColorSet) color;

            switch (colorEnum)
            {
                case ColorSet.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case ColorSet.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case ColorSet.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case ColorSet.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case ColorSet.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case ColorSet.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    break;
            }

            Console.WriteLine(stroka);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            var inputString = Console.ReadLine();

            Console.WriteLine("Choose the color of console: (0 - white, 1 - red, 2 - green, 3 - yellow, 4 - blue, 5 - magenta)");
            var color = Convert.ToInt32(Console.ReadLine());

            Print(inputString, color);

            Console.ReadKey();
        }
    }
}
