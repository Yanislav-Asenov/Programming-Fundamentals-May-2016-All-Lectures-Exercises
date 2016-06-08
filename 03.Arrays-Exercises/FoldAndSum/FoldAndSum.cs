using System;
using System.Linq;

namespace FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = inputArr.Length / 4;

            int[] upperArray = new int[2 * k];
            upperArray = FillUpperArray(inputArr, k);

            int[] lowerArray = new int[2 * k];
            lowerArray = FillLowerArray(inputArr, k);

            int[] resultArray = new int[2 * k];
            resultArray = FillResultArray(upperArray, lowerArray, k);

            Console.WriteLine(string.Join(" ", resultArray));
        }

        private static int[] FillResultArray(int[] upperArray, int[] lowerArray, int k)
        {
            int[] resultArr = new int[2 * k];
            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = upperArray[i] + lowerArray[i];
            }
            return resultArr;
        }

        private static int[] FillLowerArray(int[] inputArr, int k)
        {
            int[] resultArr = new int[2 * k];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = inputArr[k + i];
            }
            return resultArr;
        }

        private static int[] FillUpperArray(int[] inputArr, int k)
        {
            int[] resultArr = new int[2 * k];

            //Fill left part
            for (int i = 0; i < k; i++)
            {
                resultArr[i] = inputArr[k - 1 - i];
            }

            //Fill right part
            int counter = 0;
            for (int j = k; j < resultArr.Length; j++)
            {
                resultArr[j] = inputArr[inputArr.Length - 1 - counter];
                counter++;
            }

            return resultArr;
        }
    }
}
