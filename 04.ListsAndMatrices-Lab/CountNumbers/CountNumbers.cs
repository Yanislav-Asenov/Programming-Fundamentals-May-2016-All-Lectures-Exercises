using System;
using System.Linq;

namespace CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            var uniqueNums = numbers.Distinct().ToList();

            for (int i = 0; i < uniqueNums.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (uniqueNums[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0} -> {1}", uniqueNums[i], counter);
            }
        }
    }
}
