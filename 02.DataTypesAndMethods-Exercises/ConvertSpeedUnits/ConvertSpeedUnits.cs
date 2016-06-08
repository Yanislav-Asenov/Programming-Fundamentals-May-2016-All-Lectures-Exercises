﻿using System;

namespace ConvertSpeedUnits
{
    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;

            float kmSpeed = (distance / 1000.0f) / hourTime;
            float metersSpeed = kmSpeed / 3.6f;
            float milesSpeed = (distance / 1609.0f) / hourTime;

            Console.WriteLine(metersSpeed);
            Console.WriteLine(kmSpeed);
            Console.WriteLine(milesSpeed);
        }
    }
}