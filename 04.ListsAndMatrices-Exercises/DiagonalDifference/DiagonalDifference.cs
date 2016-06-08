using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            List<List<int>> matrix = new List<List<int>>();

            for (int row = 0; row < matrixSize; row++)
            {
                matrix.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
            }

            int primaryDiagonalSum = GetPrimaryDiagonalSum(matrix);
            int secondaryDiagonalSum = GetSecondaryDiagonalSum(matrix);

            int result = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(result);

        }

        private static int GetSecondaryDiagonalSum(List<List<int>> matrix)
        {
            int sum = 0;
            int currentCol = matrix.Count - 1;
            for (int row = 0; row < matrix.Count; row++)
            {
                sum += matrix[row][currentCol - row];
            }
            return sum;
        }

        private static int GetPrimaryDiagonalSum(List<List<int>> matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.Count; row++)
            {

                sum += matrix[row][row];

            }

            return sum;
        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix.Count; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
