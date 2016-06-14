using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixOperator
{
    public class MatrixOperator
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            List<List<long>> matrix = new List<List<long>>();

            //Fill matrix
            for (int row = 0; row < rows; row++)
            {
                List<long> currentRow = Console.ReadLine().Split().Select(long.Parse).ToList();
                matrix.Add(currentRow);
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string currentCommand = commandArgs[0];

                switch (currentCommand)
                {
                    case "remove":
                        ExecuteRemoveCommand(matrix, commandArgs);
                        break;
                    case "swap":
                        ExecuteSwapCommand(matrix, commandArgs);
                        break;
                    case "insert":
                        ExecuteInsertCommand(matrix, commandArgs);
                        break;
                }
                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void ExecuteInsertCommand(List<List<long>> matrix, string[] commandArgs)
        {
            int targetRow = int.Parse(commandArgs[1]);
            long number = long.Parse(commandArgs[2]);
            matrix[targetRow].Insert(0, number);
        }

        private static void ExecuteSwapCommand(List<List<long>> matrix, string[] commandArgs)
        {
            int firstRow = int.Parse(commandArgs[1]);
            int seconRow = int.Parse(commandArgs[2]);

            List<long> tempSecondRow = matrix[seconRow];
            matrix[seconRow] = matrix[firstRow];
            matrix[firstRow] = tempSecondRow;
        }

        private static void PrintMatrix(List<List<long>> matrix)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Count; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ExecuteRemoveCommand(List<List<long>> matrix, string[] commandArgs)
        {
            string commandType = commandArgs[1];

            switch (commandType)
            {
                case "positive":
                    RemovePositiveNumbers(matrix, commandArgs);
                    break;
                case "negative":
                    RemoveNegativeNumbers(matrix, commandArgs);
                    break;
                case "odd":
                    RemoveOddNumbers(matrix, commandArgs);
                    break;
                case "even":
                    RemoveEvenNumbers(matrix, commandArgs);
                    break;
            }

        }

        private static void RemoveEvenNumbers(List<List<long>> matrix, string[] commandArgs)
        {
            bool isRow = commandArgs[2] == "row";

            if (isRow)
            {
                int targetRow = int.Parse(commandArgs[3]);
                for (int col = 0; col < matrix[targetRow].Count; col++)
                {
                    if (matrix[targetRow][col] % 2 == 0)
                    {
                        matrix[targetRow].RemoveAt(col);
                        col--;
                    }
                }
            }
            else
            {
                int targetCol = int.Parse(commandArgs[3]);
                for (int row = 0; row < matrix.Count; row++)
                {
                    bool isColValid = targetCol < matrix[row].Count && targetCol >= 0;
                    if (isColValid)
                    {
                        if (matrix[row][targetCol] % 2 == 0)
                        {
                            matrix[row].RemoveAt(targetCol);
                        }
                    }
                }
            }

        }

        private static void RemoveOddNumbers(List<List<long>> matrix, string[] commandArgs)
        {
            bool isRow = commandArgs[2] == "row";

            if (isRow)
            {
                int targetRow = int.Parse(commandArgs[3]);
                for (int col = 0; col < matrix[targetRow].Count; col++)
                {
                    if (Math.Abs(matrix[targetRow][col] % 2) == 1)
                    {
                        matrix[targetRow].RemoveAt(col);
                        col--;
                    }
                }
            }
            else
            {
                int targetCol = int.Parse(commandArgs[3]);
                for (int row = 0; row < matrix.Count; row++)
                {
                    bool isColValid = targetCol < matrix[row].Count && targetCol >= 0;
                    if (isColValid)
                    {
                        if (Math.Abs(matrix[row][targetCol] % 2) == 1)
                        {
                            matrix[row].RemoveAt(targetCol);
                        }
                    }
                }
            }
        }

        private static void RemoveNegativeNumbers(List<List<long>> matrix, string[] commandArgs)
        {
            bool isRow = commandArgs[2] == "row";

            if (isRow)
            {
                int targetRow = int.Parse(commandArgs[3]);
                for (int col = 0; col < matrix[targetRow].Count; col++)
                {
                    if (matrix[targetRow][col] < 0)
                    {
                        matrix[targetRow].RemoveAt(col);
                        col--;
                    }
                }
            }
            else
            {
                int targetCol = int.Parse(commandArgs[3]);
                for (int row = 0; row < matrix.Count; row++)
                {
                    bool isColValid = targetCol < matrix[row].Count && targetCol >= 0;
                    if (isColValid)
                    {
                        if (matrix[row][targetCol] < 0)
                        {
                            matrix[row].RemoveAt(targetCol);
                        }
                    }
                }
            }
        }

        private static void RemovePositiveNumbers(List<List<long>> matrix, string[] commandArgs)
        {
            bool isRow = commandArgs[2] == "row";

            if (isRow)
            {
                int targetRow = int.Parse(commandArgs[3]);
                for (int col = 0; col < matrix[targetRow].Count; col++)
                {
                    if (matrix[targetRow][col] >= 0)
                    {
                        matrix[targetRow].RemoveAt(col);
                        col--;
                    }
                }
            }
            else
            {
                int targetCol = int.Parse(commandArgs[3]);
                for (int row = 0; row < matrix.Count; row++)
                {
                    bool isColValid = targetCol < matrix[row].Count && targetCol >= 0;
                    if (isColValid)
                    {
                        if (matrix[row][targetCol] >= 0)
                        {
                            matrix[row].RemoveAt(targetCol);
                        }
                    }
                }
            }
        }


    }
}
