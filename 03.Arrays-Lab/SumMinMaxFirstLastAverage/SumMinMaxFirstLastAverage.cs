using System;
using System.Linq;

namespace SumMinMaxFirstLastAverage
{
    public class SumMinMaxFirstLastAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("First = {0}", numbers.First());
            Console.WriteLine("Last = {0}", numbers.Last());
            Console.WriteLine("Average = {0}", (double)(numbers.Average()));
        }
    }
}
