using System;
using System.Linq;

namespace SumRevesedNumbers
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                string currentNum = numbers[i].ToString();
                long reversedNum = ReverseNumber(currentNum);
                totalSum += reversedNum;
            }
            Console.WriteLine(totalSum);
        }

        private static long ReverseNumber(string currentNum)
        {
            string result = string.Empty;
            for (int i = currentNum.Length - 1; i >= 0; i--)
            {
                result += currentNum[i];
            }
            long resultNum = long.Parse(result);
            return resultNum;
        }
    }
}
