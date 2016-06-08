using System;

namespace MasterNumbers
{
    public class MasterNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                bool isMasterNumber = IsPalindrome(i) && SumOfDigit(i) && ContainsEvenDigit(i);
                if (isMasterNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int i)
        {
            while (i > 0)
            {
                int currenDigit = i % 10;
                if (currenDigit % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool SumOfDigit(int i)
        {
            int sumOfDigits = 0;
            int number = i;
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPalindrome(int num)
        {
            string number = num.ToString();

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
