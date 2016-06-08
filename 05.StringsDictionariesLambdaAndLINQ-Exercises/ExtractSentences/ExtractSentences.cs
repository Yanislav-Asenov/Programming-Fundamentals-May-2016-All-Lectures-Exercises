using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    public class ExtractSentences
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            string[] sentences = Console.ReadLine().Split(new char[] { '.', '!', '?' });

            for (int i = 0; i < sentences.Length; i++)
            {
                char[] currentWords = sentences[i].ToCharArray();
                for (int j = 0; j < currentWords.Length; j++)
                {
                    if (!Char.IsLetter(currentWords[j]))
                    {
                        currentWords[j] = ' ';
                    }
                }

                string wordsToString = string.Join("", currentWords);
                string[] allWords = wordsToString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (allWords.Contains(keyword))
                {
                    Console.WriteLine(sentences[i].TrimStart());
                }

            }


        }
    }
}
