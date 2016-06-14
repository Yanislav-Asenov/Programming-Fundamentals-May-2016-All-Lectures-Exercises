using System;
using System.Globalization;

namespace _02.Problem
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

                long numberOfCapsules = long.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal currentCoffeeCost = (daysInMonth * numberOfCapsules) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${currentCoffeeCost:F2}");

                totalPrice += currentCoffeeCost;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
