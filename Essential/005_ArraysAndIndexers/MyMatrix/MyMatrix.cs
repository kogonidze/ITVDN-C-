using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrix
{
    class MyMatrix
    {
        public int[,] matrix;

        public MyMatrix(int numRows, int numColumns)
        {
            matrix = new int[numRows, numColumns];
            InitializeMatrix(matrix);
        }

        private void InitializeMatrix(int[,] matrix)
        {
            var random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"  {matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 50));
        }

        public void ResizeMatrix(int numRows, int numColumns)
        {
            var newMatrix = new int[numRows, numColumns];

            var minRows = Math.Min(numRows, matrix.GetLength(0));
            var minColumns = Math.Min(numColumns, matrix.GetLength(1));

            for (int i = 0; i < minRows; i++)
            {
                for (int j = 0; j < minColumns; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }

            matrix = newMatrix; 
        }

        public void ShowPartOfMatrix(int numRows, int numColumns)
        {
            if (numRows > matrix.GetLength(0) || numColumns > matrix.GetLength(1))
            {
                Console.WriteLine("You are trying to go beyound the bounds of the array!");
                return;
            }

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    Console.Write($" {matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
