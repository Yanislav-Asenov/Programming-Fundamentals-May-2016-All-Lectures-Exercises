using System;

namespace IntegerToHexAndBinary
{
    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string hexNum = Convert.ToString(number, 16).ToUpper();
            string binaryNum = Convert.ToString(number, 2);
            Console.WriteLine(hexNum);
            Console.WriteLine(binaryNum);
        }
    }
}
