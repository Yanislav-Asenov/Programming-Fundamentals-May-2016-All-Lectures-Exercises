using System;
using System.Linq;

namespace SortShortWords
{
    public class SortShortWords
    {
        public static void Main()
        {
            string separators = ".,:;()[]\"'\\/!? ";
            char[] separatorsArray = separators.ToCharArray();

            string[] words = Console.ReadLine()
                .ToLower()
                .Split(separatorsArray, StringSplitOptions.RemoveEmptyEntries)
                .Where(a => a.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
