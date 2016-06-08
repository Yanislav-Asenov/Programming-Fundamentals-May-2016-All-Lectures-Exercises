using System;

namespace PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0 && i != number) return false;
            }
            return true;
        }
    }
}
