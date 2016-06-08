using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    public class PrimesInGivenRange
    {
        public static void Main()
        {
            long startNum = long.Parse(Console.ReadLine());
            long endNum = long.Parse(Console.ReadLine());
            PrintPrimesInGivenRange(startNum, endNum);
        }

        private static void PrintPrimesInGivenRange(long startNum, long endNum)
        {
            List<long> primeNumbers = new List<long>();
            for (long i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", primeNumbers));
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
