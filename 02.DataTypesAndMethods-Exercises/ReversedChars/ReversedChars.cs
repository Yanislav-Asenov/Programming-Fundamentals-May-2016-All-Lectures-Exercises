using System;

namespace ReversedChars
{
    public class ReversedChars
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            string result = string.Format($"{thirdChar}{secondChar}{firstChar}");
            Console.WriteLine(result);
        }
    }
}
