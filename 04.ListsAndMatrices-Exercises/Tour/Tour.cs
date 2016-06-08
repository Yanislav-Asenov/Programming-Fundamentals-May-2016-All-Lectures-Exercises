using System;
using System.Linq;

namespace Tour
{
    public class Tour
    {
        public static void Main()
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numberOfCities, numberOfCities];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }

            int[] route = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            int startRow = 0;

            for (int i = 0; i < route.Length; i++)
            {
                int startCol = route[i];
                sum += matrix[startRow, startCol];
                startRow = startCol;
            }
            Console.WriteLine(sum);

        }

    }
}
