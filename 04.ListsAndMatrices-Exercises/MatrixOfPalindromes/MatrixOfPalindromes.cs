using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            int[] matrixRowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixRowCol[0];
            int cols = matrixRowCol[1];
            int[,] matrix = new int[rows, cols];

            char firstLetter = 'a';

            for (int row = 0; row < rows; row++)
            {
                char middleLetter = firstLetter;
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{firstLetter}{middleLetter++}{firstLetter} ");
                }
                firstLetter++;
                Console.WriteLine();
            }

        }
    }
}
