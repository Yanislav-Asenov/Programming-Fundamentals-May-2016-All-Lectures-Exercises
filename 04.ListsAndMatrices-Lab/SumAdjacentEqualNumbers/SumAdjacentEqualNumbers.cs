using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i - 1] == numbers[i])
                    {
                        numbers[i - 1] = numbers[i] + numbers[i];
                        numbers.RemoveAt(i);
                        isSorted = false;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
