using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEvenNumbers
{
    class Program
    {
        public static IEnumerable<int> GetEvenNumbers(int[] inputArray)
        {
            foreach (var item in inputArray)
            {
                if (item % 2 == 0)
                {
                    yield return item;
                }
            }

            yield break;
        }

        static void Main(string[] args)
        {
            var inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            var evenNumbers = GetEvenNumbers(inputArray);

            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
