using System;

namespace ReverseArrayOfStrings
{
    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            Array.Reverse(input);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
