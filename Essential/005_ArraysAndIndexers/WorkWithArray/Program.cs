using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithArray
{
    class Program
    {
        private static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            var array = new MyArray().array;

            Console.WriteLine("MAX VALUE: ");
            CompareAlgorithms(array, (arr) => MyArray.GetMaxValue(arr), () => array.Max());

            Console.WriteLine("MIN VALUE: ");
            CompareAlgorithms(array, (arr) => MyArray.GetMinValue(arr), () => array.Min());

            Console.WriteLine("SUM OF THE ELEMENTS: ");
            CompareAlgorithms(array, (arr) => MyArray.GetSumOfElements(arr), () => array.Sum());

            Console.WriteLine("Arithmetical mean: ");
            CompareAlgorithms(array, (arr) => MyArray.GetArithmeticalMean(arr), () => array.Average());

            Console.WriteLine("ODD VALUES: ");
            MyArray.GetOddValues(array);

            Console.ReadKey();
        }

        static void CompareAlgorithms<T>(int[] array, Func<int[], T> myAlgo, Func<T> dotnetAlgo)
        {
            stopwatch.Start();
            var resultInMyAlgo = myAlgo(array);
            stopwatch.Stop();

            var elapsedTimeMyAlgo = stopwatch.ElapsedTicks;

            stopwatch.Restart();
            var resultInDotnetAlgo = dotnetAlgo();
            stopwatch.Stop();

            var elapsedTimeDotnetAlgo = stopwatch.ElapsedTicks;
            Console.WriteLine($"Result in my algo is: {resultInMyAlgo}");
            Console.WriteLine($"Result in dotnet algo is: {resultInDotnetAlgo}");

            Console.WriteLine($"My algo takes: {elapsedTimeMyAlgo}, dotnet algo takes: {elapsedTimeDotnetAlgo}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
