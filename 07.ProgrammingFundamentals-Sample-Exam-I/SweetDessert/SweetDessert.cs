using System;

namespace SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            long numberOfGuests = long.Parse(Console.ReadLine());
            decimal priceOfBanana = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBarries = decimal.Parse(Console.ReadLine());

            int numberOfSets = (int)Math.Ceiling((decimal)numberOfGuests / 6);

            decimal bananasNeeded = numberOfSets * 2;
            decimal eggsNeeded = numberOfSets * 4;
            decimal kilosOfBarriesNeeded = numberOfSets * 0.2m;

            decimal totalCost = bananasNeeded * priceOfBanana + eggsNeeded * priceOfEggs + kilosOfBarriesNeeded * priceOfBarries;

            if (totalCost <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:F2}lv.");
            }
            else
            {
                decimal moneyNeeded = totalCost - amountOfCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded:F2}lv more.");
            }
        }
    }
}
