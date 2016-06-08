using System;
using System.Linq;

namespace HourglassSum
{
    public class HourglassSum
    {
        public static void Main()
        {
            long[,] matrix = new long[6, 6];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                long[] currentRow = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            long maxSum = long.MinValue;

            for (int row = 0; row < 6 - 2; row++)
            {
                for (int col = 0; col < 6 - 2; col++)
                {
                    long tempSum = GetSumOfHourglass(matrix, row, col);
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }

        private static long GetSumOfHourglass(long[,] matrix, int row, int col)
        {
            long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                + matrix[row + 1, col + 1] + matrix[row + 2, col]
                + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
            return sum;
        }
    }
}
