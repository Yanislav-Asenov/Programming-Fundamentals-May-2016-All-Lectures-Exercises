using System;
using System.Linq;

namespace FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] leftPart = numbers.Take(k).Reverse().ToArray();

            int[] rightPart = numbers.Reverse().Take(k).ToArray();

            int[] upperRow = leftPart.Concat(rightPart).ToArray();

            int[] lowerRow = numbers.Skip(k).Take(2 * k).ToArray();

            int[] result = upperRow.Select((x, pos) => x + lowerRow[pos]).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
