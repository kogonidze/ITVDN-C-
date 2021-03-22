using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList<T>
    {
        private T[] Elements { get; set; }
        private int position = -1;

        public MyList()
        {
            Elements = new T[0];
        }

        public void Add(T element)
        {
            var newElements = new T[Elements.Length + 1];

            Array.Copy(Elements, newElements, Elements.Length);

            newElements[Elements.Length] = element;

            Elements = newElements;
        }

        public T this[int index]
        {
            get
            {
                return Elements[index];
            }
        }

        public bool MoveNext()
        {
            if(position < Elements.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public int Count
        {
            get
            {
                return Elements.Length;
            }
        }


        public T Current => Elements[position];


        public void Dispose()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < Elements.Length - 1)
                {
                    position++;
                    yield return Elements[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }


        }
    }
}
