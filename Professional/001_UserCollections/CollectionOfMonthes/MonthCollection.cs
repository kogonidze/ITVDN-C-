using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfMonthes
{
    class MonthCollection : IEnumerable, IEnumerator
    {
        private Month[] monthes;
        private int[] numberOfDaysInMonth;

        public MonthCollection()
        {
            monthes = new Month[12] {Month.January, Month.February, 
                    Month.March, Month.April, Month.May, Month.June,
                    Month.July, Month.August, Month.September, 
                    Month.October, Month.November, Month.December};

            numberOfDaysInMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        }

        public int Count => monthes.Length;

        int position = -1;

        public object Current => monthes[position];

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public string GetMonthByOrderNumber(int index)
        {
            if ((index-1) >= 0 && (index-1) < Count)
            {
                return monthes[index-1].ToString();
            }

            return "There is no month with such index!";
        }

        public string GetMonthByNumberOfDays(int numberOfDays)
        {
            var indexes = new List<int>();

            for (int i = 0; i < numberOfDaysInMonth.Length; i++)
            {
                if (numberOfDays.Equals(numberOfDaysInMonth[i]))
                {
                    indexes.Add(i);
                }
            }

            var monthes = String.Empty;

            for (int i = 0; i < indexes.Count; i++)
            {
                monthes += GetMonthByOrderNumber(indexes[i]+1) + ' ';
            }

            return monthes;
        }

        public bool MoveNext()
        {
            if (position < monthes.Length - 1)
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
