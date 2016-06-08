using System;

namespace CircleArea
{
    public class CircleArea
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", Math.PI * radius * radius);
        }
    }
}
