using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    public class FootballLeague
    {
        public static void Main()
        {
            string key = Console.ReadLine();

            Dictionary<string, int> leagueStandings = new Dictionary<string, int>();
            Dictionary<string, int> teamGoals = new Dictionary<string, int>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "final")
                {
                    break;
                }
                //Get team names
                int indexOfKey = inputLine.IndexOf(key);
                inputLine = inputLine.Remove(0, indexOfKey + key.Length);
                string homeTeam = inputLine.Substring(0, inputLine.IndexOf(key));
                inputLine = inputLine.Remove(0, inputLine.IndexOf(key) + key.Length);
                inputLine = inputLine.Remove(0, inputLine.IndexOf(key) + key.Length);
                string awayTeam = inputLine.Substring(0, inputLine.IndexOf(key));
                inputLine = inputLine.Remove(0, awayTeam.Length + key.Length);

                //Extract team scores
                int indexOfScore = inputLine.IndexOf(":");
                int[] teamScores = ExtractTeamScores(inputLine, indexOfScore);
                int homeTeamScore = teamScores[0];
                int awayTeamScore = teamScores[1];

                //Reverse team names
                homeTeam = ReverseTeamName(homeTeam);
                awayTeam = ReverseTeamName(awayTeam);


                //Add teams in league standings
                if (!leagueStandings.ContainsKey(homeTeam))
                {
                    leagueStandings.Add(homeTeam, 0);
                }
                if (!leagueStandings.ContainsKey(awayTeam))
                {
                    leagueStandings.Add(awayTeam, 0);
                }

                //Add home team goals
                if (teamGoals.ContainsKey(homeTeam))
                {
                    teamGoals[homeTeam] += homeTeamScore;
                }
                else
                {
                    teamGoals.Add(homeTeam, homeTeamScore);
                }

                //Add away team goals
                if (teamGoals.ContainsKey(awayTeam))
                {
                    teamGoals[awayTeam] += awayTeamScore;
                }
                else
                {
                    teamGoals.Add(awayTeam, awayTeamScore);
                }

                //Add points in league standings
                if (homeTeamScore == awayTeamScore)
                {
                    leagueStandings[homeTeam]++;
                    leagueStandings[awayTeam]++;
                }
                else if (homeTeamScore > awayTeamScore)
                {
                    leagueStandings[homeTeam] += 3;
                }
                else
                {
                    leagueStandings[awayTeam] += 3;
                }
            }

            PrintInformation(leagueStandings, teamGoals);
        }

        private static void PrintInformation(Dictionary<string, int> leagueStandings, Dictionary<string, int> topGoalsScored)
        {
            Console.WriteLine("League standings:");
            int counter = 1;
            foreach (var team in leagueStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counter}. {team.Key} {team.Value}");
                counter++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in topGoalsScored.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        private static int[] ExtractTeamScores(string inputLine, int indexOfScore)
        {
            int[] resultNumbers = new int[2];

            // Extract away team score
            string awayTeamScore = string.Empty;
            int index = indexOfScore + 1;

            while (index < inputLine.Length && char.IsDigit(inputLine[index]))
            {
                awayTeamScore += inputLine[index];
                index++;
            }

            resultNumbers[1] = int.Parse(awayTeamScore);

            //Extract home team score
            index = indexOfScore - 1;
            string homeTeamScore = string.Empty;

            while (index >= 0 && char.IsDigit(inputLine[index]))
            {
                homeTeamScore += inputLine[index];
                index--;
            }

            char[] tempArr = homeTeamScore.ToCharArray();
            Array.Reverse(tempArr);
            resultNumbers[0] = int.Parse(string.Join("", tempArr));

            return resultNumbers;
        }

        private static string ReverseTeamName(string firstTeam)
        {
            char[] teamName = firstTeam.ToCharArray();

            for (int i = 0; i < teamName.Length; i++)
            {
                if (char.IsLower(teamName[i]))
                {
                    teamName[i] = char.ToUpper(teamName[i]);
                }
            }

            Array.Reverse(teamName);
            string result = string.Join("", teamName);
            return result;
        }
    }
}
