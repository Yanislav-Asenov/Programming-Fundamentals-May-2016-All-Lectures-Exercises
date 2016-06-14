using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationAggregation
{
    public class PopulationAggregation
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, int> numberOfCities = new Dictionary<string, int>();
            Dictionary<string, long> population = new Dictionary<string, long>();

            while (input != "stop")
            {
                char firstChar = input[0];
                string[] commandArgs;
                string countyName;
                string cityName;
                long currentCityPopulation;

                if (char.IsUpper(firstChar))
                {
                    commandArgs = input.Split('\\');
                    ClearLine(commandArgs);
                    countyName = commandArgs[0];
                    cityName = commandArgs[1];
                    currentCityPopulation = long.Parse(commandArgs[2]);

                    if (!numberOfCities.ContainsKey(countyName))
                    {
                        numberOfCities.Add(countyName, 1);
                    }
                    else
                    {
                        numberOfCities[countyName]++;
                    }

                    if (!population.ContainsKey(cityName))
                    {
                        population.Add(cityName, currentCityPopulation);
                    }
                    else
                    {
                        population[cityName] = currentCityPopulation;
                    }
                }
                else
                {
                    commandArgs = input.Split('\\');
                    ClearLine(commandArgs);
                    countyName = commandArgs[1];
                    cityName = commandArgs[0];
                    currentCityPopulation = long.Parse(commandArgs[2]);

                    if (!numberOfCities.ContainsKey(countyName))
                    {
                        numberOfCities.Add(countyName, 1);
                    }
                    else
                    {
                        numberOfCities[countyName]++;
                    }

                    if (!population.ContainsKey(cityName))
                    {
                        population.Add(cityName, currentCityPopulation);
                    }
                    else
                    {
                        population[cityName] = currentCityPopulation;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var country in numberOfCities.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{country.Key} -> {country.Value}");
            }

            foreach (var item in population.OrderByDescending(x => x.Value).Take(3).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void ClearLine(string[] currentLineInfo)
        {
            char[] prohibitedSymbols = "@#$&1234567890".ToCharArray();

            for (int i = 0; i < currentLineInfo.Length - 1; i++)
            {
                string currentWord = currentLineInfo[i];
                for (int j = 0; j < prohibitedSymbols.Length; j++)
                {
                    string currentReplacer = prohibitedSymbols[j].ToString();
                    if (currentWord.Contains(currentReplacer))
                    {
                        currentLineInfo[i] = currentLineInfo[i].Replace(currentReplacer, "");
                    }
                }
            }

        }
    }
}
