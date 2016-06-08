using System;
using System.Linq;

namespace LargestIncreasingSubsequence
{
    public class LargestIncreasingSubsequence
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            PrintLargestIncreasingSubsequence(inputNumbers);
        }

        public static void PrintLargestIncreasingSubsequence(int[] numbers)
        {
            string[] paths = new string[numbers.Length];
            int[] sizes = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                sizes[i] = 1;
                paths[i] = numbers[i] + " ";
            }

            int maxLength = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && sizes[i] < sizes[j] + 1)
                    {
                        sizes[i] = sizes[j] + 1;
                        paths[i] = paths[j] + numbers[i] + " ";
                        if (maxLength < sizes[i])
                        {
                            maxLength = sizes[i];
                        }
                    }
                }
            }

            for (int i = 0; i < sizes.Length; i++)
            {
                if (sizes[i] == maxLength)
                {
                    Console.WriteLine(paths[i]);
                    break;
                }
            }
        }
    }
}
