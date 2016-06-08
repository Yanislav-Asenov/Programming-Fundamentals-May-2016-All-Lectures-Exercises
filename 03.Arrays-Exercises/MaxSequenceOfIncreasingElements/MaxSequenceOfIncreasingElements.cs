using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLength = 0;
            int tempLength = 1;
            int endPos = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    tempLength++;
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        endPos = i;
                    }
                }
                else
                {
                    tempLength = 1;
                }
            }

            int startPos = endPos - maxLength + 1;

            List<int> result = new List<int>();

            for (int d = startPos; d <= endPos; d++)
            {
                result.Add(numbers[d]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
