using System;

namespace NumbersInReversedOrder
{
    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write("" + number[i]);
            }
            Console.WriteLine();
        }
    }
}
