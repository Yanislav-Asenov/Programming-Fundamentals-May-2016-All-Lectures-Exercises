using System;
using System.Linq;

namespace MaxPlatform
{
    public class MaxPlatform3x3
    {
        public static void Main()
        {
            long[] rowsCols = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long rows = rowsCols[0];
            long cols = rowsCols[1];
            long[,] matrix = new long[rows, cols];

            for (long row = 0; row < rows; row++)
            {
                long[] currentRow = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (long col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }


            long maxSum = long.MinValue;
            long startRow = 0;
            long startCol = 0;
            for (long row = 0; row < rows - 2; row++)
            {
                for (long col = 0; col < cols - 2; col++)
                {
                    long tempSum = CalculateTempSum(matrix, row, col);
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine(maxSum);

            for (long row = startRow; row <= startRow + 2; row++)
            {
                for (long col = startCol; col <= startCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

        }

        private static long CalculateTempSum(long[,] matrix, long row, long col)
        {
            long sum = 0;

            for (long r = row; r <= row + 2; r++)
            {
                for (long c = col; c <= col + 2; c++)
                {
                    sum += matrix[r, c];
                }
            }
            return sum;
        }
    }
}
