using System;

namespace MatrixGenerator
{
    public class MatrixGenerator
    {
        public static void Main()
        {
            string[] inputArgs = Console.ReadLine().Split();
            char type = char.Parse(inputArgs[0]);
            int rows = int.Parse(inputArgs[1]);
            int cols = int.Parse(inputArgs[2]);

            switch (type)
            {
                case 'A':
                    PrintMatrixTypeA(rows, cols);
                    break;
                case 'B':
                    PrintMatrixTypeB(rows, cols);
                    break;
                case 'C':
                    PrintMatrixTypeC(rows, cols);
                    break;
                case 'D':
                    PrintMatrixTypeD(rows, cols);
                    break;
            }
        }

        private static void PrintMatrixTypeD(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int row = 0;
            int col = 0;
            string direction = "down";
            int maxRotations = rows * cols;
            int counter = 1;

            while (counter <= maxRotations)
            {
                if (direction == "down")
                {
                    while (row < rows && matrix[row, col] == 0 && counter <= maxRotations)
                    {
                        matrix[row, col] = counter;
                        counter++;
                        row++;
                    }
                    row--;
                    col++;
                    direction = "right";
                }
                if (direction == "right")
                {
                    while (col < cols && matrix[row, col] == 0 && counter <= maxRotations)
                    {
                        matrix[row, col] = counter;
                        counter++;
                        col++;
                    }
                    col--;
                    row--;
                    direction = "up";
                }

                if (direction == "up")
                {
                    while (row >= 0 && matrix[row, col] == 0 && counter <= maxRotations)
                    {
                        matrix[row, col] = counter;
                        row--;
                        counter++;
                    }
                    row++;
                    col--;
                    direction = "left";
                }

                if (direction == "left")
                {
                    while (col >= 0 && matrix[row, col] == 0 && counter <= maxRotations)
                    {
                        matrix[row, col] = counter;
                        col--;
                        counter++;
                    }
                    col++;
                    row++;
                    direction = "down";
                }
            }

            PrintMatrix(matrix);

        }

        private static void PrintMatrixTypeC(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            int startRow = rows - 1;
            int startCol = 0;

            int counter = 1;

            while (counter <= rows * cols)
            {
                int currentStartRow = startRow;
                int currentStartCol = startCol;
                while (currentStartRow < rows && currentStartRow < cols)
                {
                    if (currentStartCol >= cols)
                    {
                        break;
                    }
                    matrix[currentStartRow, currentStartCol] = counter;
                    counter++;
                    currentStartRow++;
                    currentStartCol++;
                }

                if (startRow == 0)
                {
                    startCol++;
                }
                startRow = Math.Max(0, startRow - 1);
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrixTypeB(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int counter = 1;
            int maxMatrixValue = rows * cols;
            bool isDirectionDown = true;
            int currentCol = 0;
            while (counter <= maxMatrixValue)
            {
                if (isDirectionDown)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        matrix[row, currentCol] = counter++;
                    }
                }
                else
                {
                    for (int row = rows - 1; row >= 0; row--)
                    {
                        matrix[row, currentCol] = counter++;
                    }
                }
                isDirectionDown = !isDirectionDown;
                currentCol++;
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrixTypeA(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int counter = 1;

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row, col] = counter++;
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
