using System;

namespace CompaeCharArrays
{
    public class CompaeCharArrays
    {
        public static void Main()
        {
            char[] firstCharArr = Console.ReadLine().ToLower().ToCharArray();
            char[] secondCharArr = Console.ReadLine().ToLower().ToCharArray();

            string firstString = RemoveWhiteSpaces(firstCharArr);
            string secondString = RemoveWhiteSpaces(secondCharArr);

            int p = string.Compare(firstString.ToString(), secondString.ToString());


            if (p == 0)
            {
                Console.WriteLine(firstString);
                Console.WriteLine(secondString);
            }
            else if (p == -1)
            {
                Console.WriteLine(firstString);
                Console.WriteLine(secondString);
            }
            else
            {
                Console.WriteLine(secondString);
                Console.WriteLine(firstString);
            }
        }

        private static string RemoveWhiteSpaces(char[] firstCharArr)
        {
            string result = string.Empty;
            for (int i = 0; i < firstCharArr.Length; i++)
            {
                if (firstCharArr[i] != ' ')
                {
                    result += firstCharArr[i];
                }
            }
            return result;
        }
    }
}
