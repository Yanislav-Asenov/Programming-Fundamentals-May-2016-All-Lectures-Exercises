using System;

namespace BooleanVariable
{
    public class BooleanVariable
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            bool isYes = Convert.ToBoolean(input);
            if (isYes)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
