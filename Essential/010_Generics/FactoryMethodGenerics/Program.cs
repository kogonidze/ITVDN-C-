using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var @int = MyClass<int>.FactoryMethod();
            var @long = MyClass<long>.FactoryMethod();
            var @double = MyClass<double>.FactoryMethod();
            var myClass = MyClass<MyClass<int>>.FactoryMethod();

            Console.WriteLine($"Type: {@int.GetType()} Value: {@int}");
            Console.WriteLine($"Type: {@long.GetType()} Value: {@long}");
            Console.WriteLine($"Type: {@double.GetType()} Value: {@double}");
            Console.WriteLine($"Type: {myClass.GetType()} Value: {myClass }");
            
            Console.ReadLine();
        }
    }
}
