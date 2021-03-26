using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithMyDictionary;

namespace WorkWithNamespaces
{
    class EngToRusDict : MyClass
    {
        public new string ShowValue(string key)
        {
            return $"Key: {key}, value: {base.ShowValue(key)}";
        }
    }
}
