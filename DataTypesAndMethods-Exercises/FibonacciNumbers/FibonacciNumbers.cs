using System;

namespace FibonacciNumbers
{
    public class FibonacciNumbers
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            PrintNthFibonacciNumber(n);
        }

        private static void PrintNthFibonacciNumber(long n)
        {
            if (n == 0 || n == 1)
            {
                Console.WriteLine(1);
                return;
            }

            long firstNum = 1;
            long secondNum = 1;
            long result = 0;

            for (long i = 1; i < n; i++)
            {
                long currentNum = firstNum + secondNum;
                result = currentNum;
                firstNum = secondNum;
                secondNum = currentNum;
            }
            Console.WriteLine(result);
        }
    }
}
