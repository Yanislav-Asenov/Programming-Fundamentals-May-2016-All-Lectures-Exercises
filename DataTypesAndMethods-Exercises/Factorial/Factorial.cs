using System;
using System.Numerics;

namespace Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger result = CalculateFactorial(n);

            Console.WriteLine(result);
        }

        static BigInteger CalculateFactorial(BigInteger n)
        {
            if (n == 0)
                return 1;

            return n * CalculateFactorial(n - 1);
        }
    }
}
