using System;

namespace MaxMethod
{
    public class MaxMethod
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int maxNum = GetMax(firstNum, secondNum, thirdNum);
            Console.WriteLine(maxNum);
        }

        private static int GetMax(int firstNum, int secondNum, int thirdNum)
        {
            int result = Math.Max(Math.Max(firstNum, secondNum), thirdNum);
            return result;
        }
    }
}
