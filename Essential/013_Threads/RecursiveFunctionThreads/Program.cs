using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecursiveFunctionThreads
{
    class Program
    {
        static void RecursiveFunc()
        {
            var thread = Thread.CurrentThread;

            Console.WriteLine($"ID of thread: {thread.GetHashCode()}");
            Thread.Sleep(500);
            new Thread(RecursiveFunc).Start();

        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(RecursiveFunc);
            thread.Start();

            Console.ReadKey();
        }
    }
}
