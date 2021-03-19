using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingLetters
{
    class Program
    {
        public static Random rand = new Random();
        public static int width = Console.WindowWidth;
        public static int height = Console.WindowHeight;
        public static int[] arrSizes = GenerateArrSizes();
        public static int[] initialSteps = GenerateInitialSteps();

        static int[] GenerateArrSizes()
        {
            var arrSizes = new int[Console.WindowWidth];

            for (int i = 0; i < arrSizes.Length; i++)
            {
                arrSizes[i] = rand.Next(3, 10);
            }

            return arrSizes;
        }

        static int[] GenerateInitialSteps()
        {
            var initialSteps = new int[Console.WindowWidth];

            for (int i = 0; i < arrSizes.Length; i++)
            {
                initialSteps[i] = rand.Next(1, 20);
            }

            return initialSteps;
        }

        static int[] IncrementInitialSteps()
        {
            var newInitialSteps = new int[Console.WindowWidth];

            for (int i = 0; i < initialSteps.Length; i++)
            {
                if (initialSteps[i] + 1 == height)
                {
                    newInitialSteps[i] = (initialSteps[i] + 1) % 30;
                }
                else
                {
                    newInitialSteps[i] = initialSteps[i] + 1;
                }

            }

            initialSteps = newInitialSteps;

            return initialSteps;
        }

        static char GenerateLetter()
        {
            return (char)rand.Next(97, 122);
        }

        static void MoveLetters(object obj)
        {
            var step = (int[])obj;

            Console.Clear();
            char[,] array = new char[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i + 1 < arrSizes[j])
                    {
                        if (i + step[j] < height)
                        {
                            array[i + step[j], j] = GenerateLetter();
                        }
                        else if (i + step[j]%height == height)
                        {
                            array[0, j] = GenerateLetter();
                        }
                        else
                        {
                            array[i + (step[j]-height), j] = GenerateLetter();
                        }
                    }
                }
            }

            obj = IncrementInitialSteps();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i, j]);
                }
            }
        }

        static void Main(string[] args)
        {
            var array = new char[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i < arrSizes[j])
                    {
                        array[i + initialSteps[j], j] = GenerateLetter();
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i,j]);
                }
            }

            while (true)
            {
                Thread.Sleep(500);
                new Thread(MoveLetters).Start(initialSteps);
            }

            Console.ReadKey();
        }
    }
}
