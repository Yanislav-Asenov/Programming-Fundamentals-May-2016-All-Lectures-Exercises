using System;

namespace SoftUniAirline
{
    public class SoftUniAirline
    {
        public static void Main()
        {
            int numberOfFlights = int.Parse(Console.ReadLine());

            decimal overallProfit = 0m;

            for (int i = 0; i < numberOfFlights; i++)
            {
                int adultPassengersCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthPassengersCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumntionPerHour = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = adultPassengersCount * adultTicketPrice + youthPassengersCount * youthTicketPrice;
                decimal expenses = flightDuration * fuelConsumntionPerHour * fuelPricePerHour;

                decimal profit = income - expenses;
                if (income >= expenses)
                {
                    Console.WriteLine($"You are ahead with {profit:F3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:F3}$.");
                }

                overallProfit += profit;
            }

            Console.WriteLine($"Overall profit -> {overallProfit:F3}$.");

            decimal averageProfit = overallProfit / numberOfFlights;
            Console.WriteLine($"Average profit -> {averageProfit:F3}$.");
        }
    }
}
