using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniWaterSupplies
{
    public class SoftUniWaterSupplies
    {
        public static void Main()
        {
            double totalAmountOfWater = double.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int bottleCapacity = int.Parse(Console.ReadLine());


            int bottlesLeft = 0;
            double totalLitersNeeded = 0;
            List<int> bottlesLeftIndexes = new List<int>();
            int outOfWaterIndex = -1;
            if ((int)totalAmountOfWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    double currentLittersNeeded = bottleCapacity - bottles[i];
                    totalAmountOfWater -= currentLittersNeeded;
                    if (totalAmountOfWater <= 0)
                    {
                        outOfWaterIndex = i;
                        bottles[i] += totalAmountOfWater + currentLittersNeeded;
                        break;
                    }
                    bottles[i] += currentLittersNeeded;
                }

                if (outOfWaterIndex < bottles.Length - 1 && outOfWaterIndex >= 0)
                {
                    Console.WriteLine("We need more water!");
                    for (int j = 0; j < bottles.Length; j++)
                    {
                        if (bottles[j] < bottleCapacity)
                        {
                            bottlesLeft++;
                            bottlesLeftIndexes.Add(j);
                            double currentLitersNeeded = bottleCapacity - bottles[j];
                            totalLitersNeeded += currentLitersNeeded;
                        }
                    }

                    Console.WriteLine("Bottles left: {0}", bottlesLeft);
                    Console.WriteLine("With indexes: {0}", string.Join(", ", bottlesLeftIndexes));
                    Console.WriteLine("We need {0} more liters!", totalLitersNeeded);
                }
                else
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", totalAmountOfWater);
                }

            }
            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    double currentLittersNeeded = bottleCapacity - bottles[i];
                    totalAmountOfWater -= currentLittersNeeded;
                    if (totalAmountOfWater <= 0)
                    {
                        outOfWaterIndex = i;
                        bottles[i] += totalAmountOfWater + currentLittersNeeded;
                        break;
                    }
                    bottles[i] += currentLittersNeeded;
                }

                if (outOfWaterIndex > 0)
                {
                    Console.WriteLine("We need more water!");
                    for (int j = bottles.Length - 1; j >= 0; j--)
                    {
                        if (bottles[j] < bottleCapacity)
                        {
                            bottlesLeft++;
                            bottlesLeftIndexes.Add(j);
                            double currentLitersNeeded = bottleCapacity - bottles[j];
                            totalLitersNeeded += currentLitersNeeded;
                        }
                    }

                    Console.WriteLine("Bottles left: {0}", bottlesLeft);
                    Console.WriteLine("With indexes: {0}", string.Join(", ", bottlesLeftIndexes));
                    Console.WriteLine("We need {0} more liters!", totalLitersNeeded);
                }
                else
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", totalAmountOfWater);
                }
            }
        }
    }
}
