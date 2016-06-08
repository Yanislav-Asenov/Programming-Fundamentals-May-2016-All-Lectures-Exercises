using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonStrings
{
    public class CommonStrings
    {
        public static void Main()
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            for (int firstIndex = 0; firstIndex < firstWord.Length; firstIndex++)
            {
                for (int secondIndex = 0; secondIndex < secondWord.Length; secondIndex++)
                {
                    if (firstWord[firstIndex] == secondWord[secondIndex])
                    {
                        Console.WriteLine("yes");
                        return;
                    }
                }
            }
            Console.WriteLine("no");
        }
    }
}
