using System;

namespace DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string[] daysOfTheWeek =
            {
                "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"
            };

            int userInput = int.Parse(Console.ReadLine());
            bool notValidDay = true;
            for (int i = 0; i < daysOfTheWeek.Length; i++)
            {
                if (i + 1 == userInput)
                {
                    Console.WriteLine(daysOfTheWeek[i]);
                    notValidDay = false;
                }
            }
            if (notValidDay)
            {
                Console.WriteLine("invalid day");
            }
        }
    }
}
