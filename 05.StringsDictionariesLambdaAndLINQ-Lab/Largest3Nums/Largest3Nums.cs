using System;
using System.Linq;

namespace Largest3Nums
{
    public class Largest3Nums
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split().Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
