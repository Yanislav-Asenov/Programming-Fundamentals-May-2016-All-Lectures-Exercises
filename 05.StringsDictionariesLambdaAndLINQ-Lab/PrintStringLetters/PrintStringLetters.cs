using System;

namespace PrintStringLetters
{
    public class PrintStringLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'", i, input[i]);
            }
        }
    }
}
