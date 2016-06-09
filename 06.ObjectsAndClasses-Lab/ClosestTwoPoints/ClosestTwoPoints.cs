using System;
using System.Linq;

namespace ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            Point[] points = ReadPoints();
            Point[] closestTwoPoints = FindClosestTwoPoints(points);
            Console.WriteLine("{0:f3}", Point.CalcDistance(closestTwoPoints[0], closestTwoPoints[1]));
            PrintPoint(closestTwoPoints[0]);
            PrintPoint(closestTwoPoints[1]);
        }

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] result = new Point[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = Point.ReadPoint();
            }
            return result;
        }

        static void PrintPoint(Point p1)
        {
            Console.WriteLine("({0}, {1})", p1.X, p1.Y);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double currentDistance = Point.CalcDistance(points[p1], points[p2]);
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        closestTwoPoints = new Point[]
                        {
                        points[p1],
                        points[p2]
                        };
                    }
                }
            }
            return closestTwoPoints;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double CalcDistance(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            return Math.Sqrt(a * a + b * b);
        }

        public static Point ReadPoint()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point() { X = coordinates[0], Y = coordinates[1] };
            return point;
        }
    }
}
