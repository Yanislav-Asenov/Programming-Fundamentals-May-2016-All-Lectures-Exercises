using System;
using System.Linq;

namespace RoundingNumbers
{
    public class RoundingNumbers
    {
        public static void Main()
        {
            double[] numbersToRound = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNumbers = new int[numbersToRound.Length];

            for (int i = 0; i < numbersToRound.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbersToRound[i], MidpointRounding.AwayFromZero);
            }

            for (int index = 0; index < roundedNumbers.Length; index++)
            {
                Console.WriteLine("{0} => {1}", numbersToRound[index], roundedNumbers[index]);
            }
        }
    }
}
