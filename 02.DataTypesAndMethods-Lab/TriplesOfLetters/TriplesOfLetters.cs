using System;

namespace TriplesOfLetters
{
    public class TriplesOfLetters
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (char firstChar = 'a'; firstChar < 'a' + number; firstChar++)
            {
                for (char secondsCHar = 'a'; secondsCHar < 'a' + number; secondsCHar++)
                {
                    for (char thirdChar = 'a'; thirdChar < 'a' + number; thirdChar++)
                    {
                        Console.WriteLine("{0}{1}{2}", firstChar, secondsCHar, thirdChar);
                    }
                }
            }
        }
    }
}
