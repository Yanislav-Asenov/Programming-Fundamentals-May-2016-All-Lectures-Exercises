using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] specialNumAndPower = Console.ReadLine().Split();
            string specialNumber = specialNumAndPower[0];
            int power = int.Parse(specialNumAndPower[1]);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    UnleashBomb(numbers, specialNumber, power, i);
                }
            }

            long finalSum = CalculateSum(numbers);
            Console.WriteLine(finalSum);

        }

        private static long CalculateSum(string[] numbers)
        {
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != string.Empty)
                {
                    long currentNum = long.Parse(numbers[i]);
                    sum += currentNum;
                }
            }
            return sum;
        }

        private static void UnleashBomb(string[] numbers, string specialNumber, int power, int i)
        {
            int startPos = Math.Max(i - power, 0);
            int endPos = Math.Min(numbers.Length - 1, i + power);
            for (int index = startPos; index <= endPos; index++)
            {
                numbers[index] = string.Empty;
            }
        }
    }
}
