using System;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public static void Main()
        {
            int primeRange = int.Parse(Console.ReadLine());
            bool[] primes = new bool[primeRange + 1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;

            for (int j = 2; j < primes.Length; j++)
            {
                for (int p = j + j; p < primes.Length; p += j)
                {
                    if (primes[p])
                    {
                        primes[p] = false;
                    }
                }
            }

            for (int u = 0; u < primes.Length; u++)
            {
                if (primes[u])
                {
                    Console.Write(u + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
