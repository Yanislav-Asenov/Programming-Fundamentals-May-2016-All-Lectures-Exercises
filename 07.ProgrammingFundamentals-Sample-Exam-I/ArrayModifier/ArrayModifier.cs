using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    public class ArrayModifier
    {
        public static void Main()
        {
            List<long> numbers =
                Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] lineArgs = input.Split();
                string command = lineArgs[0];

                switch (command)
                {
                    case "swap":
                        ExecuteSwapCommand(lineArgs, numbers);
                        break;
                    case "multiply":
                        ExecuteMultiplyCommand(lineArgs, numbers);
                        break;
                    case "decrease":
                        ExecuteDecreaseCommand(lineArgs, numbers);
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void ExecuteDecreaseCommand(string[] lineArgs, List<long> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        private static void ExecuteMultiplyCommand(string[] lineArgs, List<long> numbers)
        {
            int firstIndex = int.Parse(lineArgs[1]);
            int secondIndex = int.Parse(lineArgs[2]);
            numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
        }

        private static void ExecuteSwapCommand(string[] lineArgs, List<long> numbers)
        {
            int firstIndex = int.Parse(lineArgs[1]);
            int secondIndex = int.Parse(lineArgs[2]);

            long tempNum = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = tempNum;
        }
    }
}
