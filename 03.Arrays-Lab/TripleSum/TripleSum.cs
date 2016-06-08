using System;
using System.Linq;

namespace TripleSum
{
    public class TripleSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool tripleSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int a = numbers[i];
                    int b = numbers[j];
                    int sum = a + b;

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", a, b, sum);
                        tripleSum = true;
                    }
                }
            }

            if (!tripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
