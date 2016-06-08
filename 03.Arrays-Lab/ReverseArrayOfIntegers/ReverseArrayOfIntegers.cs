using System;

namespace ReverseArrayOfIntegers
{
    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            int numberOfInputNumers = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberOfInputNumers];

            for (int i = 0; i < numberOfInputNumers; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
