using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList<T>
    {
        public int Count
        {
            get
            {
                return Elements.Length;
            }
        }
        private T[] Elements { get; set; }

        public MyList()
        {
            Elements = new T[0];
        }

        public void Add(T newElem)
        {
            var newArray = new T[Elements.Length + 1];
            Array.Copy(Elements, newArray, Elements.Length);
            newArray[Elements.Length] = newElem;

            Elements = newArray;
        }

        public T this[int index]
        {
            get
            {
                return Elements[index];
            }
        }

    }
}
