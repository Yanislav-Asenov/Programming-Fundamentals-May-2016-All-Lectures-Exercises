using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .OrderBy(x => x)
            .ToList();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
