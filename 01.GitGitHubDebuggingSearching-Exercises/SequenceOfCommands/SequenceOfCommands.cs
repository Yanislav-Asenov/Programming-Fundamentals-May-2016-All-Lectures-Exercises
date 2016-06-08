namespace Arrays
{
    using System;
    using System.Linq;

    public class SequenceOfElements
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (!input.Equals("stop"))
            {
                string[] line = input.Split(' ');
                string command = line[0];

                int[] args = new int[2];

                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    args[0] = int.Parse(line[1]);
                    args[1] = int.Parse(line[2]);
                }

                PerformAction(ref array, command, args);

                PrintArray(array);

                input = Console.ReadLine();
            }
        }

        static void PerformAction(ref long[] arr, string action, int[] args)
        {
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    arr = ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    arr = ArrayShiftRight(arr);
                    break;
            }
        }

        private static long[] ArrayShiftRight(long[] array)
        {
            long[] tempArray = new long[array.Length];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                tempArray[i] = array[i - 1];
            }
            tempArray[0] = array[array.Length - 1];

            return tempArray;
        }

        private static long[] ArrayShiftLeft(long[] array)
        {
            long[] tempArray = new long[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                tempArray[i] = array[i + 1];
            }
            tempArray[tempArray.Length - 1] = array[0];

            return tempArray;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
