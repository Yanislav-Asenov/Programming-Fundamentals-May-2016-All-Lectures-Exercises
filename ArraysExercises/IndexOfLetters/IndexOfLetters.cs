using System;

namespace IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != ' ')
                {
                    char currentChar = inputString[i];
                    int decreaser = 0;
                    if (Char.IsUpper(currentChar))
                    {
                        decreaser = 65;
                    }
                    else
                    {
                        decreaser = 97;
                    }
                    int letterIndex = currentChar - decreaser;
                    Console.WriteLine("" + currentChar + " -> " + letterIndex);
                }
            }
        }
    }
}
