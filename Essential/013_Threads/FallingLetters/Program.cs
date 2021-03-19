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
        public static object obj = new object();

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

            PrintArray(array);
        }

        static void PrintArray(char[,] array)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (CheckIfFirstSymbolInChain(array, i, j))
                    {
                        lock(obj)
                        {
                            ColouredOutputInConsole(array[i, j], ConsoleColor.White);
                        }
                    }
                    else if (CheckIfSecondSymbolInChain(array, i, j))
                    {
                        lock (obj)
                        {
                            ColouredOutputInConsole(array[i, j], ConsoleColor.Green);
                        }
                    }
                    else
                    {
                        lock (obj)
                        {
                            ColouredOutputInConsole(array[i, j], ConsoleColor.DarkGreen);
                        }
                    }
                }
            }
        }

        static bool CheckIfFirstSymbolInChain(char[,] array, int i, int j)
        {
            return array[(i + 1) % height, j] == 0;
        }

        static bool CheckIfSecondSymbolInChain(char[,] array, int i, int j)
        {
            return array[(i + 2) % height, j] == 0 && array[(i + 1) % height, j] != 0;
        }

        static void ColouredOutputInConsole(char ch, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(ch);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void InitializeArray(char[,] array)
        {
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
        }

        static void Main(string[] args)
        {
            var array = new char[height, width];

            InitializeArray(array);

            PrintArray(array);

            while (true)
            {
                Thread.Sleep(1000);
                new Thread(MoveLetters).Start(initialSteps);
            }
        }
    }
}
