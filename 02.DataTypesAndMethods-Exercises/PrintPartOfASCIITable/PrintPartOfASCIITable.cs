using System;

namespace PrintPartOfASCIITable
{
    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                char currentChar = (char)i;
                Console.Write(currentChar + " ");
            }
            Console.WriteLine();
        }
    }
}
