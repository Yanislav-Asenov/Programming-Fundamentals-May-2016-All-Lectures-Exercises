using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElemets
{
    public class MaxSequenceOfEqualElemets
    {
        public static void Main()
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();

            //if (numbers.Count == 1)
            //{
            //    Console.WriteLine(numbers[0]);
            //    return;
            //}

            int maxLength = 1;
            int temporaryLength = 1;
            int endPos = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    temporaryLength++;
                    if (temporaryLength > maxLength)
                    {
                        maxLength = temporaryLength;
                        endPos = i;
                    }
                }
                else
                {
                    temporaryLength = 1;
                }
            }


            int startPos = endPos - maxLength + 1;
            List<long> result = new List<long>();
            for (int i = startPos; i <= endPos; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
