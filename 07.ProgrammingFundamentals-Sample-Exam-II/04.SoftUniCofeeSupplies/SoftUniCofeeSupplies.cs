using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniCofeeSuplies
{
    static void Main()
    {
        string[] delimiters = Console.ReadLine().Split();
        string firstDelimiter = delimiters[0];
        string secondDelimiter = delimiters[1];

        Dictionary<string, string> coffeeTypeByPeople = new Dictionary<string, string>();
        Dictionary<string, int> coffeeTypeByQuantity = new Dictionary<string, int>();

        ReadInformation(coffeeTypeByPeople, coffeeTypeByQuantity, firstDelimiter, secondDelimiter);
        MonitorCoffeeUsage(coffeeTypeByPeople, coffeeTypeByQuantity);
        PrintReports(coffeeTypeByPeople, coffeeTypeByQuantity);
    }

    private static void PrintReports(Dictionary<string, string> coffeeTypeByPeople, Dictionary<string, int> coffeeTypeByQuantity)
    {
        Console.WriteLine("Coffee Left:");

        var filteredCoffeeTypeByQuantity =
            coffeeTypeByQuantity.Where(coffeeType => coffeeType.Value > 0).ToDictionary(x => x.Key, x => x.Value);

        foreach (var coffeeType in filteredCoffeeTypeByQuantity.OrderByDescending(coffeeType => coffeeType.Value))
        {
            Console.WriteLine("{0} {1}", coffeeType.Key, coffeeType.Value);
        }

        Console.WriteLine("For:");

        var coffeeLeftForPeople =
            coffeeTypeByPeople.Where(person => filteredCoffeeTypeByQuantity.ContainsKey(person.Value))
                .OrderBy(person => person.Value)
                .ThenByDescending(X => X.Key);
        foreach (var coffee in coffeeLeftForPeople)
        {
            Console.WriteLine("{0} {1}", coffee.Key, coffee.Value);
        }
    }

    private static void MonitorCoffeeUsage(Dictionary<string, string> coffeeTypeByPeople, Dictionary<string, int> coffeeTypeByQuantity)
    {
        foreach (var coffeeType in coffeeTypeByQuantity)
        {
            if (coffeeType.Value <= 0)
            {
                Console.WriteLine("Out of {0}", coffeeType.Key);
            }
        }

        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of week")
            {
                break;
            }

            string[] commandArgs = inputLine.Split();
            string personName = commandArgs[0];
            int quantity = int.Parse(commandArgs[1]);

            string coffeeType = coffeeTypeByPeople[personName];
            coffeeTypeByQuantity[coffeeType] -= quantity;

            if (coffeeTypeByQuantity[coffeeType] <= 0)
            {
                Console.WriteLine("Out of {0}", coffeeType);
            }
        }
    }

    private static void ReadInformation(Dictionary<string, string> coffeeTypeByPeople, Dictionary<string, int> coffeeTypeByQuantity, string firstDelimiter, string secondDelimiter)
    {
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of info")
            {
                break;
            }

            if (inputLine.Contains(firstDelimiter))
            {
                int indexOfDelimiter = inputLine.IndexOf(firstDelimiter);
                string personName = inputLine.Substring(0, indexOfDelimiter);
                string coffeeType = inputLine.Substring(indexOfDelimiter + firstDelimiter.Length);

                if (coffeeTypeByPeople.ContainsKey(personName))
                {
                    coffeeTypeByPeople[personName] = coffeeType;
                }
                else
                {
                    coffeeTypeByPeople.Add(personName, coffeeType);
                }

                if (!coffeeTypeByQuantity.ContainsKey(coffeeType))
                {
                    coffeeTypeByQuantity.Add(coffeeType, 0);
                }
            }
            else
            {
                int indexOfDelimiter = inputLine.IndexOf(secondDelimiter);
                string coffeeType = inputLine.Substring(0, indexOfDelimiter);
                int quantity = int.Parse(inputLine.Substring(indexOfDelimiter + secondDelimiter.Length));

                if (coffeeTypeByQuantity.ContainsKey(coffeeType))
                {
                    coffeeTypeByQuantity[coffeeType] += quantity;
                }
                else
                {
                    coffeeTypeByQuantity.Add(coffeeType, quantity);
                }
            }
        }
    }
}