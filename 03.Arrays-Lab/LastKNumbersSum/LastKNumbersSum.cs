using System;

namespace LastKNumbersSum
{
    public class LastKNumbersSum
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long start = Math.Max(0, i - k);
                long end = n - 1;
                long sum = 0;
                for (long j = start; j <= end; j++)
                {
                    sum += numbers[j];
                }
                numbers[i] = sum;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
