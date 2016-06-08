using System;

namespace FilledSquare
{
    public class FilledSquare
    {
        public static void Main()
        {
            int userInput = int.Parse(Console.ReadLine());

            DrawHeaderLine(userInput);
            for (int i = 0; i < userInput - 2; i++)
            {
                DrawMiddlePart(userInput);
            }
            DrawHeaderLine(userInput);
        }

        static void DrawHeaderLine(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }

        static void DrawMiddlePart(int size)
        {
            Console.Write("-");
            for (int i = 0; i < size - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
