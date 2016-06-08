using System;
using System.Collections.Generic;

namespace CountOddOccurrencies
{
    public class CountOddOccurrencies
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> oddOccurrencies = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!oddOccurrencies.ContainsKey(words[i]))
                {
                    oddOccurrencies[words[i]] = 1;
                }
                else
                {
                    oddOccurrencies[words[i]]++;
                }
            }

            List<string> result = new List<string>();
            foreach (var word in oddOccurrencies)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
