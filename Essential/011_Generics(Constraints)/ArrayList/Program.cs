using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList myArrayList = new MyArrayList();

            myArrayList.Add(1);
            myArrayList.Add("hello");
            myArrayList.Add(new DateTime(2012, 2, 2));
            myArrayList.Add(2.0);

            myArrayList.GetElements();

            myArrayList.Clear();
            Console.WriteLine(myArrayList.Count);

            Console.ReadKey();
        }
    }
}
