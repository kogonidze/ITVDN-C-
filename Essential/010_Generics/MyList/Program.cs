using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var @int = new MyList<int>();

            for (int i = 0; i < 10; i++)
            {
                @int.Add(random.Next(1, 100));
            }

            Console.WriteLine(@int.Count);
            Console.WriteLine($"{@int[5]} {@int[1]}");

            var @string = new MyList<string>();
            @string.Add("Hello");
            @string.Add("World");
            @string.Add("Foo");

            Console.WriteLine(@string.Count);
            Console.WriteLine(@string[0]);

            Console.ReadKey();
        }
    }
}
