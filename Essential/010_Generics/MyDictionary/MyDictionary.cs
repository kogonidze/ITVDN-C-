using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;

        public int Count
        {
            get
            {
                return keys.Length;
            }
        }

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            var newKeys = new TKey[Count + 1];
            var newValues = new TValue[Count + 1];

            Array.Copy(keys, newKeys, Count);
            Array.Copy(values, newValues, Count);

            newKeys[Count] = key;
            newValues[Count] = value;

            keys = newKeys;
            values = newValues;
        }

        public string this[int index]
        {
            get
            {
                return $"Key: {keys[index]} Value: {values[index]}";
            }
        }
    }
}
