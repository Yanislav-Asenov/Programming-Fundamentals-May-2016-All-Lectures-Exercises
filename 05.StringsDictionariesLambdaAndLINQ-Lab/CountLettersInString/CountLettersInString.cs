using System;
using System.Linq;

namespace CountLettersInString
{
    public class CountLettersInString
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToLower().ToCharArray();
            Array.Sort(input);
            int max = input.Max();
            int[] characters = new int[max + 1];

            foreach (var ch in input)
            {
                characters[ch]++;
            }

            for (char i = (char)0; i < characters.Length; i++)
            {
                if (characters[i] != 0)
                {
                    Console.WriteLine("{0} -> {1}", i, characters[i]);
                }
            }
        }
    }
}
