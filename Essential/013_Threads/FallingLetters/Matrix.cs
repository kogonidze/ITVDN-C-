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
        public int[] arrSizes2;
        public int[] initialSteps;
        public int[] initialSteps2;

        private static Matrix matrix;

        private Matrix()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            array = new char[height, width];
            arrSizes = RandomGeneratorHelper.GenerateChainSizes();
            arrSizes2 = RandomGeneratorHelper.GenerateChainSizes();
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
            matrix.initialSteps2 = RandomGeneratorHelper.GenerateInitialSteps(matrix.arrSizes.Length)
                .Zip(matrix.initialSteps, (a, b) => a + b + 1)
                .ToArray();

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
                        array[i + matrix.initialSteps2[j], j] = RandomGeneratorHelper.GenerateLetter();
                    }
                }
            }
        }

        static int[] IncrementInitialSteps(int[] initialSteps)
        {
            var newInitialSteps = new int[Console.WindowWidth];

            for (int i = 0; i < initialSteps.Length; i++)
            {
                if (initialSteps[i] + 1 == matrix.height)
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

        public static void MoveLetters()
        {
            var step = (int[])matrix.initialSteps;
            var step2 = (int[])matrix.initialSteps2;

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

                        if (i + step2[j] < matrix.height)
                        {
                            array[i + step2[j], j] = RandomGeneratorHelper.GenerateLetter();
                        }
                        else if (i + step2[j] % matrix.height == matrix.height)
                        {
                            array[0, j] = RandomGeneratorHelper.GenerateLetter();
                        }
                        else
                        {
                            array[i + (step2[j] - matrix.height), j] = RandomGeneratorHelper.GenerateLetter();
                        }
                    }
                }
            }

            matrix.initialSteps = IncrementInitialSteps(matrix.initialSteps);
            matrix.initialSteps2 = IncrementInitialSteps(matrix.initialSteps2);

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
