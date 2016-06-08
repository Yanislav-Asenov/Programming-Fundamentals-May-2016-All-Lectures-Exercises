using System;

namespace ComparingFloats
{
    public class ComparingFloats
    {
        public static void Main()
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal eps = 0.000001m;

            decimal difference = Math.Abs(firstNum - secondNum);
            if (eps > difference)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
