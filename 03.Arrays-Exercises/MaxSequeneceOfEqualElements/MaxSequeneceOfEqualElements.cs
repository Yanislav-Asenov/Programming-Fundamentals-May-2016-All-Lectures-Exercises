using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequeneceOfEqualElements
{
    public class MaxSequeneceOfEqualElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLength = 0;
            int startPos = 0;
            int endPos = 0;

            int tempLength = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
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

            startPos = endPos - maxLength + 1;
            List<int> result = new List<int>();
            for (int j = startPos; j <= endPos; j++)
            {
                result.Add(numbers[j]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
