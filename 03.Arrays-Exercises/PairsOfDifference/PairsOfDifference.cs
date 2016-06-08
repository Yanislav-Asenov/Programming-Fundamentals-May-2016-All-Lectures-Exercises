using System;
using System.Linq;

namespace PairsOfDifference
{
    public class PairsOfDifference
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int differece = int.Parse(Console.ReadLine());
            int pairCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    bool areMachingDifference = Math.Abs(numbers[i] - numbers[j]) == differece;
                    if (areMachingDifference) // if numbers are matching difference
                    {
                        pairCounter++;
                    }
                }
            }
            Console.WriteLine(pairCounter);
        }
    }
}
