using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    static class ArrayListExtensions
    {
        public static void GetElements(this MyArrayList arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"{arrayList[i]}");
            }
        }
    }
}
