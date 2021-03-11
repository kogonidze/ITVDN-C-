using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    static class MyListExtensionMethods
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var elements = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                elements[i] = list[i];
            }

            return elements;
        }
    }
}
