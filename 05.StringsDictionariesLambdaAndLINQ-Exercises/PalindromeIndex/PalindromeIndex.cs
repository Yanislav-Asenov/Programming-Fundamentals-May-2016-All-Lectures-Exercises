using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    public class PalindromeIndex
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine(-1);
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                string resultWord = RemoveLetter(input, currentChar, i);
                if (IsPalindrome(resultWord))
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            
        }

        private static string RemoveLetter(string input, char currentChar, int i)
        {
            string result = string.Empty;
            for (int index = 0; index < input.Length; index++)
            {
                if (index != i)
                {
                    result += input[index];
                }
            }
            return result;
        }

        public static bool IsPalindrome(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);

            return s == backwards;
        }
    }
}
