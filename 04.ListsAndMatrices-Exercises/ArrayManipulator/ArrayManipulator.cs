using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<long> inputArray = Console.ReadLine().Split().Select(long.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];

                switch (commandType)
                {
                    case "add":
                        ExecuteAddCommand(inputArray, commandArgs);
                        break;
                    case "addMany":
                        ExecuteAddManyCommand(inputArray, commandArgs);
                        break;
                    case "contains":
                        ExecuteContainsCommand(inputArray, commandArgs);
                        break;
                    case "remove":
                        ExecuteRemoveCommand(inputArray, commandArgs);
                        break;
                    case "shift":
                        ExecuteShiftCommand(ref inputArray, commandArgs);
                        break;
                    case "sumPairs":
                        ExecuteSumPairsCommand(ref inputArray, commandArgs);
                        break;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", inputArray));
        }

        private static void ExecuteSumPairsCommand(ref List<long> inputArray, string[] commandArgs)
        {
            List<long> resultArr = new List<long>();
            for (int i = 0; i < inputArray.Count; i += 2)
            {
                if (inputArray.Count % 2 != 0 && i == inputArray.Count - 1)
                {
                    resultArr.Add(inputArray[i]);
                }
                else
                {
                    long firstNum = inputArray[i];
                    long secondNum = inputArray[i + 1];
                    resultArr.Add(firstNum + secondNum);
                }
            }

            inputArray = resultArr;
        }

        private static void ExecuteShiftCommand(ref List<long> inputArray, string[] commandArgs)
        {
            long numberOfShifts = long.Parse(commandArgs[1]) % inputArray.Count;
            for (int currentRotation = 0; currentRotation < numberOfShifts; currentRotation++)
            {
                long firstElement = inputArray[0];
                inputArray.RemoveAt(0);
                inputArray.Add(firstElement);
            }

        }

        private static void ExecuteRemoveCommand(List<long> inputArray, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);
            inputArray.RemoveAt(index);
        }

        private static void ExecuteContainsCommand(List<long> inputArray, string[] commandArgs)
        {
            long element = long.Parse(commandArgs[1]);
            if (inputArray.Contains(element))
            {
                Console.WriteLine(inputArray.IndexOf(element));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        private static void ExecuteAddManyCommand(List<long> inputArray, string[] commandArgs)
        {
            int targetIndex = int.Parse(commandArgs[1]);
            List<long> elements = new List<long>();
            for (int i = 2; i < commandArgs.Length; i++)
            {
                long currentNumber = long.Parse(commandArgs[i]);
                elements.Add(currentNumber);
            }
            inputArray.InsertRange(targetIndex, elements);
        }

        private static void ExecuteAddCommand(List<long> inputArray, string[] commandArgs)
        {
            int targetIndex = int.Parse(commandArgs[1]);
            long element = long.Parse(commandArgs[2]);
            inputArray.Insert(targetIndex, element);
        }
    }
}
