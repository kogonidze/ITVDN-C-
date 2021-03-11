using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class MyArrayList
    {
        private object[] elements;

        public MyArrayList()
        {
            elements = new object[0];
        }

        public int Count
        {
            get
            {
                return elements.Length;
            }
        }

        public void Add(object item)
        {
            var newElements = new object[elements.Length + 1];
            Array.Copy(elements, newElements, elements.Length);
            newElements[elements.Length] = item;

            elements = newElements;
        }

        public string this[int index]
        {
            get
            {
                return elements[index].ToString();
            }
        }

        public void Clear()
        {
            elements = new object[0];
        }
    }
}
