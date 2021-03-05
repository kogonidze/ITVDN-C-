using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithArray
{
    class MyArray
    {
        private static readonly int arrayLength =
                Convert.ToInt32(ConfigurationManager.AppSettings["ArrayLength"]);

        public int[] array = new int[arrayLength]; 

        public MyArray()
        {
            InitializeArray(array);
        }

        private void InitializeArray(int[] array)
        {
            var random = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(1, 1000);
            }
        }

        public static int GetMaxValue(int[] array)
        {
            var max = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int GetMinValue(int[] array)
        {
            var min = Int32.MaxValue;

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int GetSumOfElements(int[] array)
        {
            var sum = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static double GetArithmeticalMean(int[] array)
        {
            return GetSumOfElements(array) / (double)array.Length;
        }


        public static void GetOddValues(int[] array)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
