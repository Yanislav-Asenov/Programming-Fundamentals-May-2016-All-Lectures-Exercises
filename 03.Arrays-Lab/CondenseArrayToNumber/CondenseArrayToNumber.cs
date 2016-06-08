using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] condensedArr = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {

                    int sum = numbers[i] + numbers[i + 1];
                    condensedArr[i] = sum;
                }
                numbers = condensedArr;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
