using System;
using System.Linq;

namespace EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (inputArray.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                int leftSum = CalcLeftSum(inputArray, i);
                int rightSum = CalcRightSum(inputArray, i);

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }

        private static int CalcRightSum(int[] inputArray, int i)
        {
            if (i == inputArray.Length - 1)
            {
                return 0;
            }

            int startIndex = Math.Min(i + 1, inputArray.Length - 1);
            int endIndex = inputArray.Length - 1;
            int sumOfElements = 0;

            for (int j = startIndex; j <= endIndex; j++)
            {
                sumOfElements += inputArray[j];
            }
            return sumOfElements;
        }

        private static int CalcLeftSum(int[] inputArray, int i)
        {
            if (i == 0)
            {
                return 0;
            }
            int startIndex = Math.Max(i - 1, 0);
            int endIndex = 0;
            int sumOfElements = 0;

            for (int j = startIndex; j >= endIndex; j--)
            {
                sumOfElements += inputArray[j];
            }
            return sumOfElements;
        }
    }
}
