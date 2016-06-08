using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { '.', ',', '?', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            List<string> result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (IsPalindrome(words[i]))
                {
                    result.Add(words[i]);
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(", ", result));
        }

        public static bool IsPalindrome(string s)
        {
            return s == new string(s.Reverse().ToArray());
        }
    }
}
