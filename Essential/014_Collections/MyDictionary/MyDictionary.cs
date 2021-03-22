using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        private TKey[] keys;
        private TValue[] values;
        private int position = -1;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public int Count
        {
            get
            {
                return keys.Length;
            }
        }

        public object Current => keys[position];

        public void Add(TKey key, TValue value)
        {
            var newKeys = new TKey[keys.Length + 1];
            var newValues = new TValue[keys.Length + 1];

            Array.Copy(keys, newKeys, keys.Length);
            Array.Copy(values, newValues, values.Length);

            newKeys[keys.Length] = key;
            newValues[keys.Length] = value;

            keys = newKeys;
            values = newValues;
        }

        public TValue this[int index]
        {
            get
            {
                if (index >= 0 && index < keys.Length)
                {
                    return values[index];
                }

                return default(TValue);
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                var index = -1;

                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Equals(key))
                    {
                        index = i;
                    }
                }

                if (index != -1)
                {
                    return values[index];
                }

                return default(TValue);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            if (position < keys.Length - 1)
            {
                position++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
