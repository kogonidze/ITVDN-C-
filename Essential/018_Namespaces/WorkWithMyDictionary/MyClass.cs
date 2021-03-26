using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDictionary;

namespace WorkWithMyDictionary
{
    public class MyClass
    {
        private MyDictionary<string, string> dictionary;

        public MyClass()
        {
            dictionary = new MyDictionary<string, string>();
        }

        public int Count { get { return dictionary.Count; } }

        public void Add(string key, string value)
        {
            dictionary.Add(key, value);
        }

        public string ShowValue(string key)
        {
            return dictionary[key];
        }
    }
}
