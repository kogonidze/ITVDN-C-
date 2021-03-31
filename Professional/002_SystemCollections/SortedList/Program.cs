using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedListInt1 = new SortedList<int, string>();
            FillSortedListInt(sortedListInt1);
            PrintSortedList(sortedListInt1);           
            Console.WriteLine(new string('-', 50));

            var sortedListInt2 = new SortedList<int, string>(new DescendingComparer());
            FillSortedListInt(sortedListInt2);
            PrintSortedList(sortedListInt2);
            Console.WriteLine(new string('-', 50));

            var sortedListString1 = new SortedList<string, string>();
            FillSortedListString(sortedListString1);
            PrintSortedList(sortedListString1);
            Console.WriteLine(new string('-', 50));

            var sortedListString2 = new SortedList<string, string>(new DescendingComparer());
            FillSortedListString(sortedListString2);
            PrintSortedList(sortedListString2);

            Console.ReadKey();
        }

        static void FillSortedListInt(SortedList<int, string> list)
        {
            list.Add(5, "Fedorov");
            list.Add(1, "Alekseev");
            list.Add(4, "Vasilev");
            list.Add(2, "Andreev");
            list.Add(3, "Petrov");
        }

        static void FillSortedListString(SortedList<string, string> list)
        {
            list.Add("table", "стол");
            list.Add("book", "книга");
            list.Add("energy", "энергия");
            list.Add("train", "поезд");
            list.Add("orange", "апельсин");
        }

        static void PrintSortedList<TKey, TValue>(SortedList<TKey, TValue> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }

        }
    }
}
