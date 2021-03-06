using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortExtensionMethod
{
    class Program
    {
        static void InitializeArray(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = random.Next(1, 100);
            }
        }

        static void Main(string[] args)
        {
            var array = new int[20];

            InitializeArray(array);

            var sortedArray = array.BubbleSortAsc();

            Console.ReadKey();
        }
    }
}
