using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareStructAndClass
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }

        static void Main(string[] args)
        {
            var myStruct = new MyStruct();
            var myClass = new MyClass();

            myClass.change = "not changed";
            myStruct.change = "not changed";

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            Console.ReadKey();
        }
    }
}
