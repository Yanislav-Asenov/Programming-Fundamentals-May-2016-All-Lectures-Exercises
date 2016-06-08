using System;

namespace VariableInHexFormat
{
    public class VariableInHexFormat
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(input, 16));
        }
    }
}
