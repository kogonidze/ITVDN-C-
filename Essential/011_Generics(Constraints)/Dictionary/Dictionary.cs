using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary<TKey, TValue>
    {
        private MyList<TKey> keys;
        private MyList<TValue> values;

        public Dictionary()
        {
            keys = new MyList<TKey>();
            values = new MyList<TValue>();
        }

        public int Count
        {
            get
            {
                return keys.Count;
            }
        }

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public string this[int index]
        {
            get
            {
                return $"{keys[index]} : {values[index]}";
            }
        }

        public string this[TKey key]
        {
            get
            {
                var indexOfKey = keys[key];
                if (indexOfKey != -1)
                {
                    return $"{keys[indexOfKey]} : {values[indexOfKey]}";
                }

                return "There is no such element in dictionary!";
            }
        }

        public bool Contains(TKey key)
        {
            return keys.Contains(key);
        }

        public void Clear()
        {
            keys.Clear();
            values.Clear();
        }
    }
}
