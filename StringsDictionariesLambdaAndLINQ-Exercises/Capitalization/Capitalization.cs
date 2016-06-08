using System;

namespace Capitalization
{
    public class Capitalization
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { '.', ' ', '!', ',', '?', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                word[0] = char.ToUpper(word[0]);
                string wordToUpper = string.Join("", word);
                words[i] = wordToUpper;
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
