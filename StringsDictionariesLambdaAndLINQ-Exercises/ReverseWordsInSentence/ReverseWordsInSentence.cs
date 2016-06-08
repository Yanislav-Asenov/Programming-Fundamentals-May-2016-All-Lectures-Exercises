using System;
using System.Linq;

namespace ReverseWordsInSentence
{
    public class ReverseWordsInSentence
    {
        public static void Main()
        {
            char[] separators = string.Format(".,:;=()&[]\"'\\/!? ").ToCharArray();
            string inputText = Console.ReadLine();
            string[] words = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            char[] allWordsCharacters = string.Join("", words).ToCharArray();
            string[] separatorsString = inputText.Split(allWordsCharacters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"{words[i]}{separatorsString[i]}");
            }

            Console.WriteLine();
        }
    }
}
