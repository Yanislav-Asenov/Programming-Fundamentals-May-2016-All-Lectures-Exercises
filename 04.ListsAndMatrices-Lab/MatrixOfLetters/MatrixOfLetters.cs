using System;

namespace MatrixOfLetters
{
    public class MatrixOfLetters
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] charMatrix = new char[rows, cols];
            char startChar = 'A';

            for (int row = 0; row < charMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < charMatrix.GetLength(1); col++)
                {
                    charMatrix[row, col] = startChar;
                    Console.Write(charMatrix[row, col] + " ");
                    startChar++;
                }
                Console.WriteLine();
            }
        }
    }
}
