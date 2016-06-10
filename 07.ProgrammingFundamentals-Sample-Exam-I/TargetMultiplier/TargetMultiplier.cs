using System;
using System.Linq;

namespace TargetMultiplier
{
    public class TargetMultiplier
    {
        public static void Main()
        {
            int[] arrayDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = arrayDimensions[0];
            int cols = arrayDimensions[1];
            long[,] matrix = new long[rows, cols];
            FillMatrix(matrix, rows, cols);

            int[] targetCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int targetRow = targetCoordinates[0];
            int targetCol = targetCoordinates[1];

            ExecuteTargetMultiplier(matrix, targetRow, targetCol);
            PrintMatrix(matrix, rows, cols);
        }

        private static void PrintMatrix(long[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ExecuteTargetMultiplier(long[,] matrix, int targetRow, int targetCol)
        {
            int startRow = targetRow - 1;
            int endRow = targetRow + 1;
            int startCol = targetCol - 1;
            int endCol = targetCol + 1;

            long multiplier = matrix[targetRow, targetCol];
            long sum = 0;
            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    if (row == targetRow && col == targetCol)
                    {
                        continue;
                    }
                    else
                    {
                        sum += matrix[row, col];
                        matrix[row, col] *= multiplier;
                    }

                }
            }
            matrix[targetRow, targetCol] = sum * multiplier;
        }

        private static void FillMatrix(long[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
