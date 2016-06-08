using System;

namespace Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = persons / (double)capacity;

            Console.WriteLine("{0}", Math.Ceiling(courses));
        }
    }
}
