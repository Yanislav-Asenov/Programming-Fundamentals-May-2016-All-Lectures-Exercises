using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintAReceipt
{
    public class PrintAReceipt
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine(@"/----------------------\");

            double total = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("| {0, 20:F2} |", numbers[i]);
                total += numbers[i];
            }

            Console.WriteLine(@"|----------------------|");
            Console.WriteLine("| Total: {0, 13:F2} |", total);
            Console.WriteLine(@"\----------------------/");
        }
    }
}
