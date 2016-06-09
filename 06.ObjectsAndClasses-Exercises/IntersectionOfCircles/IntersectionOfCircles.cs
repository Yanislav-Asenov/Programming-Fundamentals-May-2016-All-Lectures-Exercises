using System;
using System.Linq;

namespace IntersectionOfCircles
{
    public class IntersectionOfCircles
    {
        public static void Main()
        {
            Circle firstCircle = GetCircle();
            Circle secondCircle = GetCircle();
            bool circlesIntersect = firstCircle.Center.DistanceTo(secondCircle.Center) <=
                                    firstCircle.Radius + secondCircle.Radius;
            if (circlesIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static Circle GetCircle()
        {
            int[] data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Point center = new Point() { X = data[0], Y = data[1] };
            Circle circle = new Circle() { Center = center, Radius = data[2] };
            return circle;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double DistanceTo(Point p)
        {
            double deltaX = Math.Abs(X - p.X);
            double deltaY = Math.Abs(Y - p.Y);
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }
}
