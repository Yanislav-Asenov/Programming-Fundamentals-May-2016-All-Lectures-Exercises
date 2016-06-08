using System;
using System.Linq;

namespace MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxNum = -1;
            int maxCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int temporaryCounter = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        temporaryCounter++;
                        if (temporaryCounter > maxCount)
                        {
                            maxCount = temporaryCounter;
                            maxNum = numbers[i];
                        }
                    }
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
