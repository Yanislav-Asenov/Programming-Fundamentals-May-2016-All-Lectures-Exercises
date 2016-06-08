using System;

namespace ChangeToUppercase
{
    class ChangeToUppercase
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputAsCharArr = input.ToCharArray();

            while (true)
            {
                int indexOfOpeningTag = input.IndexOf("<upcase>");
                int indexOfClosingTag = input.IndexOf("</upcase>");
                if (indexOfOpeningTag == -1)
                {
                    break;
                }
                string content = string.Empty;
                for (int i = indexOfOpeningTag + 8; i < indexOfClosingTag; i++)
                {
                    content += inputAsCharArr[i];
                }
                string stringToBeReplaced = string.Format("<upcase>" + content + "</upcase>");
                content = content.ToUpper();
                input = input.Replace(stringToBeReplaced, content);
                inputAsCharArr = input.ToCharArray();
            }

            Console.WriteLine(input);


        }
    }
}
