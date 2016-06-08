using System;
using System.Linq;

namespace RotateAMatrix
{
    public class RotateAMatrix
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];

            FillMatrix(rows, cols, matrix);

            int resultMatrixRows = cols;
            int resultMatrixCols = rows;
            string[,] resultMatrix = new string[resultMatrixRows, resultMatrixCols];

            for (int row = 0; row < resultMatrixRows; row++)
            {
                for (int col = resultMatrixCols - 1; col >= 0; col--)
                {
                    resultMatrix[row, col] = matrix[rows - col - 1, row];
                }
            }

            PrintMatrix(resultMatrixRows, resultMatrixCols, resultMatrix);
        }

        private static void PrintMatrix(int resultMatrixRows, int resultMatrixCols, string[,] resultMatrix)
        {
            for (int row = 0; row < resultMatrixRows; row++)
            {
                for (int col = 0; col < resultMatrixCols; col++)
                {
                    Console.Write(resultMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] currentWords = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentWords[col];
                }
            }
        }
    }
}
