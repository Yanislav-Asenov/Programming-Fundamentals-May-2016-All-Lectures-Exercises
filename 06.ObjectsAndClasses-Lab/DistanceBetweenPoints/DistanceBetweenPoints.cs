using System;
using System.Linq;

namespace DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = p1.CalcDistance(p2);
            Console.WriteLine($"{distance:F3}");
        }

        private static Point ReadPoint()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point currentPoint = new Point();
            currentPoint.X = coordinates[0];
            currentPoint.Y = coordinates[1];
            return currentPoint;
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double CalcDistance(Point p2)
        {
            double sideA = Math.Abs(this.X - this.X);
            double sideB = Math.Abs(p2.Y - p2.Y);

            return Math.Sqrt(sideA * sideA + sideB * sideB);
        }
    }
}
