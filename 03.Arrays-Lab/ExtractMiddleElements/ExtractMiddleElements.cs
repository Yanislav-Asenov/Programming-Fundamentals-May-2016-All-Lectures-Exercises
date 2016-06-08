using System;
using System.Linq;

namespace ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int index = 0; index < numbers.Length; index++)
            {
                int startIndex = 0;
                int endIndex = 0;

                if (numbers.Length == 1)
                {
                    Console.WriteLine(numbers[index]);
                }
                else if (numbers.Length % 2 == 0)
                {
                    startIndex = numbers.Length / 2 - 1;
                    endIndex = startIndex + 1;

                    if (index >= startIndex && index <= endIndex)
                    {
                        Console.WriteLine(numbers[index]);
                    }
                }
                else
                {
                    startIndex = numbers.Length / 2 - 1;
                    endIndex = startIndex + 2;
                    if (index >= startIndex && index <= endIndex)
                    {
                        Console.WriteLine(numbers[index]);
                    }
                }
            }
        }
    }
}
