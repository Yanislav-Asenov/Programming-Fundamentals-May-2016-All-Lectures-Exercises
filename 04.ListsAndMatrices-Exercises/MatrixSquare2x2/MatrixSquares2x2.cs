using System;
using System.Linq;

namespace MatrixSquare2x2
{
    public class MatrixSquares2x2
    {
        public static void Main()
        {
            int[] matrixRowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixRowsAndCols[0];
            int cols = matrixRowsAndCols[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int numberOfSquares = CountTheNumberOfSquares(matrix);
            Console.WriteLine(numberOfSquares);

        }

        private static int CountTheNumberOfSquares(char[,] matrix)
        {
            int numberOfSquares = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    bool isSquare = matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row + 1, col] == matrix[row + 1, col + 1];
                    if (isSquare)
                    {
                        numberOfSquares++;
                    }
                }
            }
            return numberOfSquares;
        }
    }
}

