using System;

namespace LargestCommonEnd
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');
            int minLength = Math.Min(firstArr.Length, secondArr.Length);

            int leftToRightLength = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    leftToRightLength++;
                }
                else
                {
                    break;
                }
            }

            int rightToLeftLenth = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                {
                    rightToLeftLenth++;
                }
                else
                {
                    break;
                }
            }

            if (leftToRightLength > rightToLeftLenth)
            {
                Console.WriteLine(leftToRightLength);
            }
            else
            {
                Console.WriteLine(rightToLeftLenth);
            }

        }
    }
}
