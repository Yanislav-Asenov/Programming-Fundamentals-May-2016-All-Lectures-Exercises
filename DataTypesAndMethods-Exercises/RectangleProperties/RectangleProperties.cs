using System;

namespace RectangleProperties
{
    public class RectangleProperties
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = width * 2 + height * 2;
            Console.WriteLine(perimeter);

            double area = width * height;
            Console.WriteLine(area);

            double diagonal = Math.Sqrt(height * height + width * width);
            Console.WriteLine(diagonal);
        }
    }
}
