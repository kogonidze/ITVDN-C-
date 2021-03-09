using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesArray
{
    class Program
    {
        public delegate double AvgDelegate(Delegate[] delegates);
        public delegate int Delegate();

        static void Main(string[] args)
        {
            var rand = new Random();

            Delegate[] randArr = { () => rand.Next(1, 10), () => rand.Next(1,100), () => rand.Next(1,1000)};
            AvgDelegate avg = (array) =>
            {
                var sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i]();
                }

                return (double)sum / array.Length;
            };

            Console.WriteLine(avg(randArr));

            Console.ReadKey();
        }
    }
}
