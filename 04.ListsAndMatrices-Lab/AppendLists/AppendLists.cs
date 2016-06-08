using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            string[] stringOfNumbers = Console.ReadLine().Split('|');

            List<int> numbers = new List<int>();

            for (int i = stringOfNumbers.Length - 1; i >= 0; i--)
            {
                int[] currentNumbers =
                    stringOfNumbers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                for (int j = 0; j < currentNumbers.Length; j++)
                {
                    numbers.Add(currentNumbers[j]);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
