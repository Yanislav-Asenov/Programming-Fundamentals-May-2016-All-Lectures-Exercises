using System;
using System.Collections.Generic;
using System.Globalization;

namespace CountWorkDays
{
    public class CountWorkDays
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            List<Date> holidays = GetHolidays();

            int workingDays = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                bool isWorkingDay = IsHoliday(date, holidays)
                                    && date.DayOfWeek != DayOfWeek.Sunday
                                    && date.DayOfWeek != DayOfWeek.Saturday;
                if (isWorkingDay)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }

        private static bool IsHoliday(DateTime date, List<Date> holidays)
        {
            foreach (var holiday in holidays)
            {
                if (holiday.Month == date.Month && holiday.Day == date.Day)
                {
                    return false;
                }
            }
            return true;
        }

        private static List<Date> GetHolidays()
        {
            List<Date> holidays = new List<Date>();
            holidays.Add(new Date() { Month = 1, Day = 1 });
            holidays.Add(new Date() { Month = 3, Day = 3 });
            holidays.Add(new Date() { Month = 5, Day = 1 });
            holidays.Add(new Date() { Month = 5, Day = 6 });
            holidays.Add(new Date() { Month = 5, Day = 24 });
            holidays.Add(new Date() { Month = 9, Day = 6 });
            holidays.Add(new Date() { Month = 9, Day = 22 });
            holidays.Add(new Date() { Month = 11, Day = 1 });
            holidays.Add(new Date() { Month = 12, Day = 24 });
            holidays.Add(new Date() { Month = 12, Day = 25 });
            holidays.Add(new Date() { Month = 12, Day = 26 });
            return holidays;
        }
    }

    class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
    }
}
