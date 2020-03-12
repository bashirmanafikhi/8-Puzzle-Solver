using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Library
{
    internal static class MatrixCalculations
    {
        public static int[,] GetMatrix(int n1, int n2)
        {
            int[,] matrix = new int[n1, n2];

            int counter = 1;
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < n2; j++)
                    matrix[i, j] = counter++;

            matrix[n1 - 1, n2 - 1] = 0;

            return matrix;
        }


        public static (int, int) FindInMatrix(int[,] matrix, int value)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == value)
                        return (i, j);
            return (-1, -1);
        }


        /// <summary>
        /// This function uses the Fisher-Yates algorithm
        /// </summary>
        /// <param name="matrix">the matrix to be shuffled</param>
        public static void Shuffle(int[,] matrix) 
        {
            int rowLength = matrix.GetLength(1);
            Random random = new Random();

            for (int i = matrix.Length - 1; i > 0; i--)
            {
                int i0 = i / rowLength;
                int i1 = i % rowLength;

                int j = random.Next(i + 1);
                int j0 = j / rowLength;
                int j1 = j % rowLength;

                int temp = matrix[i0, i1];
                matrix[i0, i1] = matrix[j0, j1];
                matrix[j0, j1] = temp;
            }
        }

        public static int[,] Copy(int[,] source)
        {
            int[,] destination = new int [source.GetLength(0), source.GetLength(1)];

            for (int i = 0; i < destination.GetLength(0); i++)
                for (int j = 0; j < destination.GetLength(1); j++)
                    destination[i, j] = source[i, j];

            return destination;
        }


        public static int CalculateManhattanDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }

    }
}
