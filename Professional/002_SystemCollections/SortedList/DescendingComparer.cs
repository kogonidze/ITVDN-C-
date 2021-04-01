using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class DescendingComparer : IComparer<int>, IComparer<string>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (x < y)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int Compare(string x, string y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (x.CompareTo(y) < 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
