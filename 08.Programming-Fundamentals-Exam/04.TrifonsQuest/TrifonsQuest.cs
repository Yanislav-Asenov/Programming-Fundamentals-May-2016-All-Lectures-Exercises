using System;
using System.Linq;

namespace _04.Problem
{
    public class TrifonsQuest
    {
        public static void Main()
        {
            long totalHealth = long.Parse(Console.ReadLine());

            int[] matrixDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            char[,] matrix = new char[rows, cols];
            FillMatrix(matrix, rows, cols);

            int totalTurns;
            if (CompleteQuest(rows, cols, matrix, out totalTurns, ref totalHealth)) return;

            Console.WriteLine("Quest completed!");
            Console.WriteLine($"Health: {totalHealth}");
            Console.WriteLine($"Turns: {totalTurns}");
        }

        private static bool CompleteQuest(int rows, int cols, char[,] matrix, out int totalTurns, ref long totalHealth)
        {
            totalTurns = 0;
            int col = 0;
            bool isDirectionDown = true;
            int counter = 1;

            while (counter <= rows * cols)
            {
                if (col >= cols)
                {
                    break;
                }

                if (isDirectionDown)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        if (matrix[row, col] == 'F')
                        {
                            int damageTaken = totalTurns / 2;
                            totalHealth = totalHealth - damageTaken;
                            if (totalHealth <= 0)
                            {
                                Console.WriteLine($"Died at: [{row}, {col}]");
                                return true;
                            }
                            totalTurns++;
                            counter++;
                        }
                        else if (matrix[row, col] == 'H')
                        {
                            int healPower = totalTurns / 3;
                            totalHealth = totalHealth + healPower;
                            totalTurns++;
                            counter++;
                        }
                        else if (matrix[row, col] == 'T')
                        {
                            totalTurns += 3;
                            counter++;
                        }
                        else if (matrix[row, col] == 'E')
                        {
                            totalTurns++;
                            counter++;
                        }
                    }
                    col++;
                }
                else
                {
                    for (int row = rows - 1; row >= 0; row--)
                    {
                        if (matrix[row, col] == 'F')
                        {
                            int damageTaken = totalTurns / 2;
                            totalHealth = totalHealth - damageTaken;
                            if (totalHealth <= 0)
                            {
                                Console.WriteLine($"Died at: [{row}, {col}]");
                                return true;
                            }
                            totalTurns++;
                            counter++;
                        }
                        else if (matrix[row, col] == 'H')
                        {
                            int healPower = totalTurns / 3;
                            totalHealth = totalHealth + healPower;
                            totalTurns++;
                            counter++;
                        }
                        else if (matrix[row, col] == 'T')
                        {
                            totalTurns += 3;
                            counter++;
                        }
                        else if (matrix[row, col] == 'E')
                        {
                            totalTurns++;
                            counter++;
                        }
                    }

                    col++;
                }

                isDirectionDown = !isDirectionDown;
            }
            return false;
        }


        private static void FillMatrix(char[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
