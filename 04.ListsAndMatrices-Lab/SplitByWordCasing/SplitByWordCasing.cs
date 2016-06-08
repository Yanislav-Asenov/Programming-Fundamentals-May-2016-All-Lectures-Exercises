using System;
using System.Collections.Generic;

namespace SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            char[] separators = ",;:.!()\"'/\\[] ".ToCharArray();
            string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            foreach (var word in words)
            {
                int lowerLetterCounter = 0;
                int upperLetterCounter = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        lowerLetterCounter++;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        upperLetterCounter++;
                    }
                }

                if (word.Length == lowerLetterCounter)
                {
                    lowerCaseWords.Add(word);
                }
                else if (word.Length == upperLetterCounter)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
