using System;
using System.Linq;

namespace SumArrays
{
    public class SumArrays
    {
        public static void Main()
        {
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = Math.Max(firstLine.Length, secondLine.Length);

            int[] sumArray = new int[n];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstLine[i % firstLine.Length] + secondLine[i % secondLine.Length];
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
