using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> occurencies = new SortedDictionary<double, int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (!occurencies.ContainsKey(inputNumbers[i]))
                {
                    occurencies[inputNumbers[i]] = 1;
                }
                else
                {
                    occurencies[inputNumbers[i]]++;
                }
            }

            foreach (var number in occurencies)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
