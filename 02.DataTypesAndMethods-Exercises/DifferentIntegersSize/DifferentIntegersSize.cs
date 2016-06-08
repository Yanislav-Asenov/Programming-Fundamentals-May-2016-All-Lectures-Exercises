using System;
using System.Numerics;

namespace DifferentIntegersSize
{
    public class DifferentIntegersSize
    {
        public static void Main()
        {
            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());

            if (inputNumber > long.MaxValue || inputNumber < long.MinValue)
            {
                Console.WriteLine(inputNumber + " can't fit in any type");
                return;
            }

            Console.WriteLine(inputNumber + " can fit in:");
            if (inputNumber <= sbyte.MaxValue && inputNumber >= sbyte.MinValue)
            {
                Console.WriteLine("* sbyte");
            }
            if (inputNumber <= byte.MaxValue && inputNumber >= 0)
            {
                Console.WriteLine("* byte");
            }
            if (inputNumber <= short.MaxValue && inputNumber >= short.MinValue)
            {
                Console.WriteLine("* short");
            }
            if (inputNumber <= ushort.MaxValue && inputNumber >= 0)
            {
                Console.WriteLine("* ushort");
            }
            if (inputNumber <= int.MaxValue && inputNumber >= int.MinValue)
            {
                Console.WriteLine("* int");
            }
            if (inputNumber <= uint.MaxValue && inputNumber >= 0)
            {
                Console.WriteLine("* uint");
            }
            if (inputNumber <= long.MaxValue && inputNumber >= long.MinValue)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
