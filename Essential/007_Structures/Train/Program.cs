using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher MinskPassazhirsky = new Dispatcher();

            MinskPassazhirsky.InitializeTrains();

            Console.WriteLine(MinskPassazhirsky[17]);
            Console.WriteLine(MinskPassazhirsky[1]);
            Console.WriteLine(MinskPassazhirsky[99]);
            Console.WriteLine(MinskPassazhirsky[34]);
            Console.WriteLine(MinskPassazhirsky[13]);
            Console.WriteLine(MinskPassazhirsky[243]);
            Console.WriteLine(MinskPassazhirsky[3]);
            Console.WriteLine(MinskPassazhirsky[7]);

            Console.ReadKey();
        }
    }
}
