using System;

namespace OccurrencesInString
{
    public class OccurrencesInString
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string matchString = Console.ReadLine().ToLower();
            int counter = 0;

            int offset = 0;
            while (true)
            {
                int index = input.IndexOf(matchString, offset);
                if (index != -1)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                offset = index + 1;
            }

            Console.WriteLine(counter);
        }
    }
}
