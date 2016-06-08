using System;

namespace VowelOrDigit
{
    public class VowelOrDigit
    {
        public static void Main()
        {
            char inputChar = char.Parse(Console.ReadLine().ToLower());
            bool isDigit = Char.IsDigit(inputChar);
            bool isVowel =
                inputChar == 'a' || inputChar == 'e' || inputChar == 'i' ||
                inputChar == 'o' || inputChar == 'u' || inputChar == 'y';
            if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
