using System;
using System.Globalization;

namespace DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
