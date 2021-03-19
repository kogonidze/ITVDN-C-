using FallingLetters.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingLetters
{
    public class Matrix
    {
        public char[,] array;
        public int width;
        public int height;
        public int[] arrSizes;
        public int[] initialSteps;

        private static Matrix matrix;

        private Matrix()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            array = new char[height, width];
            arrSizes = RandomGeneratorHelper.GenerateChainSizes();
        }

        public static Matrix GetMatrix()
        {
            if (matrix == null)
            {
                matrix = new Matrix();
                matrix.ConfigureMatrix();
            }

            return matrix;
        }

        void ConfigureMatrix()
        {
            matrix.initialSteps = RandomGeneratorHelper.GenerateInitialSteps(matrix.arrSizes.Length);
            InitializeMatrix(matrix.array);
            PrintMatrix(matrix.array);
        }

        static void InitializeMatrix(char[,] array)
        {
            for (int i = 0; i < matrix.height; i++)
            {
                for (int j = 0; j < matrix.width; j++)
                {
                    if (i < matrix.arrSizes[j])
                    {
                        array[i + matrix.initialSteps[j], j] = RandomGeneratorHelper.GenerateLetter();
                    }
                }
            }
        }

        static int[] IncrementInitialSteps()
        {
            var newInitialSteps = new int[Console.WindowWidth];

            for (int i = 0; i < matrix.initialSteps.Length; i++)
            {
                if (matrix.initialSteps[i] + 1 == matrix.height)
                {
                    newInitialSteps[i] = (matrix.initialSteps[i] + 1) % 30;
                }
                else
                {
                    newInitialSteps[i] = matrix.initialSteps[i] + 1;
                }

            }

            matrix.initialSteps = newInitialSteps;

            return matrix.initialSteps;
        }

        public static void MoveLetters(object obj)
        {
            var step = (int[])obj;

            Console.Clear();
            char[,] array = new char[matrix.height, matrix.width];

            for (int i = 0; i < matrix.height; i++)
            {
                for (int j = 0; j < matrix.width; j++)
                {
                    if (i + 1 < matrix.arrSizes[j])
                    {
                        if (i + step[j] < matrix.height)
                        {
                            array[i + step[j], j] = RandomGeneratorHelper.GenerateLetter();
                        }
                        else if (i + step[j] % matrix.height == matrix.height)
                        {
                            array[0, j] = RandomGeneratorHelper.GenerateLetter();
                        }
                        else
                        {
                            array[i + (step[j] - matrix.height), j] = RandomGeneratorHelper.GenerateLetter();
                        }
                    }
                }
            }

            obj = IncrementInitialSteps();

            PrintMatrix(array);
        }

        static void PrintMatrix(char[,] array)
        {
            for (int i = 0; i < matrix.height; i++)
            {
                for (int j = 0; j < matrix.width; j++)
                {
                    if (CheckIfFirstSymbolInChain(array, i, j))
                    {
                        lock (Program.syncRoot)
                        {
                            FormattingOutputHelper.ColouredOutputInConsole(array[i, j], ConsoleColor.White);
                        }
                    }
                    else if (CheckIfSecondSymbolInChain(array, i, j))
                    {
                        lock (Program.syncRoot)
                        {
                            FormattingOutputHelper.ColouredOutputInConsole(array[i, j], ConsoleColor.Green);
                        }
                    }
                    else
                    {
                        lock (Program.syncRoot)
                        {
                            FormattingOutputHelper.ColouredOutputInConsole(array[i, j], ConsoleColor.DarkGreen);
                        }
                    }
                }
            }
        }

        static bool CheckIfFirstSymbolInChain(char[,] array, int i, int j)
        {
            return array[(i + 1) % matrix.height, j] == 0;
        }

        static bool CheckIfSecondSymbolInChain(char[,] array, int i, int j)
        {
            return array[(i + 2) % matrix.height, j] == 0 && array[(i + 1) % matrix.height, j] != 0;
        }
    }
}
