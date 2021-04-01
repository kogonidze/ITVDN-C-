using System;
using System.Collections;

namespace CollectionOfSquaresOfOddNumbers
{
    class Program
    {
        public static IEnumerable GetSquaresOfOddNumbers(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 1)
                {
                    yield return inputArray[i] * inputArray[i];
                }
            }

            yield break;
        }
        static void Main(string[] args)
        {
            var intArr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var squaresOfOddNumbers = GetSquaresOfOddNumbers(intArr);

            foreach (var number in squaresOfOddNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
