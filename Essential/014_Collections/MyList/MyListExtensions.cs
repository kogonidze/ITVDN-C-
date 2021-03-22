using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public static class MyListExtensions
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            var array = new T[list.Count()];
            var counter = -1;
            foreach (var item in list)
            {
                counter++;
                array[counter] = item;
            }

            return array;
        }
    }
}
