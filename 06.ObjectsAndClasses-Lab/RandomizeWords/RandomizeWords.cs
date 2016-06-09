using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random rng = new Random();

            while (words.Count > 0)
            {
                int currentIndex = rng.Next(0, words.Count);
                Console.WriteLine(words[currentIndex]);
                words.RemoveAt(currentIndex);
            }
        }
    }
}
