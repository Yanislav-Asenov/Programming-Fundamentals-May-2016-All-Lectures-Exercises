using System;
using System.Collections.Generic;

namespace SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < numberOfSales; i++)
            {
                string[] currentSaleInfo = Console.ReadLine().Split();
                string currentTown = currentSaleInfo[0];
                decimal price = decimal.Parse(currentSaleInfo[2]);
                decimal quantity = decimal.Parse(currentSaleInfo[3]);
                decimal average = price * quantity;

                if (salesByTown.ContainsKey(currentTown))
                {
                    salesByTown[currentTown] += average;
                }
                else
                {
                    salesByTown.Add(currentTown, average);
                }
            }

            foreach (var sale in salesByTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:F2}");
            }
        }
    }
}
