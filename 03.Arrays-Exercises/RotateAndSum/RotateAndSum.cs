using System;
using System.Linq;

namespace RotateAndSum
{
    public class RotateAndSum
    {
        public static void Main()
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());
            int[] resultArr = new int[firstArr.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                int[] currentShiftedArr = shiftRight(firstArr);

                for (int j = 0; j < resultArr.Length; j++)
                {
                    resultArr[j] += currentShiftedArr[j];
                }

                firstArr = currentShiftedArr;

            }
            Console.WriteLine(string.Join(" ", resultArr));

        }


        static public int[] shiftRight(int[] arr)
        {
            int[] demo = new int[arr.Length];

            for (int i = 1; i < arr.Length; i++)
            {
                demo[i] = arr[i - 1];
            }

            demo[0] = arr[demo.Length - 1];

            return demo;
        }
    }
}
