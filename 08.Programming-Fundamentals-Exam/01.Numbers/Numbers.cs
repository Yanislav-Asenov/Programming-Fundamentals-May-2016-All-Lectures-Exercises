using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Problem
{
    public class Numbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double averageNum = numbers.Average();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > averageNum)
                {
                    result.Add(numbers[i]);
                }
            }

            if (result.Count != 0)
            {
                Console.WriteLine(string.Join(" ", result.OrderByDescending(x => x).Take(5)));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
