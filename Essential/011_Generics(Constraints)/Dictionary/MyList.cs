using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyList<T>
    {
        private T[] elements;

        public MyList()
        {
            elements = new T[0];
        }

        public int Count
        {
            get
            {
                return elements.Length;
            }
        }
        public void Add(T item)
        {
            var newElements = new T[elements.Length + 1];
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

        public int this[T item]
        {
            get
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if ((object)elements[i] == (object)item)
                    {
                        return i;
                    }
                }

                return -1;
            }
        }

        public void Clear()
        {
            elements = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if ((object)elements[i] == (object)item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
