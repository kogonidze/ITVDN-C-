using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortExtensionMethod
{
    static class Sort
    {
        public static int[] BubbleSortAsc(this int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if (array[i] < array[j])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
