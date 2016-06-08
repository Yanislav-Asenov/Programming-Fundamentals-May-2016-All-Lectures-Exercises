using System;

namespace Greeting
{
    public class Greeting
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            string output = $"Hello, {firstName} {secondName}.\r\nYou are {age} years old.";

            Console.WriteLine(output);
        }
    }
}
