using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            var teamsByPoints = new Dictionary<string, int>();
            var teamsByGoals = new Dictionary<string, long>();

            string key = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("final"))
                    break;

                string[] tokens = input
                    .Split(new char[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstTeam = ExtractTeam(tokens[0], key);
                string secondTeam = ExtractTeam(tokens[1], key);

                int[] scores = tokens[2]
                    .Split(new char[] { ':' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int scoreA = scores[0];
                int scoreB = scores[1];
                int pointsA = 0;
                int pointsB = 0;
                if (scoreA > scoreB)
                    pointsA += 3;
                else if (scoreB > scoreA)
                    pointsB += 3;
                else if (scoreA == scoreB)
                {
                    pointsA++;
                    pointsB++;
                }

                AddToTeamsByGoals(teamsByGoals, firstTeam, scoreA);
                AddToTeamsByGoals(teamsByGoals, secondTeam, scoreB);

                AddToTeamsByPoints(teamsByPoints, firstTeam, pointsA);
                AddToTeamsByPoints(teamsByPoints, secondTeam, pointsB);
            }

            PrintOutput(teamsByPoints, teamsByGoals);
        }

        private static void PrintOutput(Dictionary<string, int> teamsByPoints, Dictionary<string, long> teamsByGoals)
        {
            Console.WriteLine("League standings:");
            var standings = teamsByPoints
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key);
            int i = 0;
            foreach (var team in standings)
            {
                ++i;
                Console.WriteLine($"{i}. {team.Key} {team.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");
            var goals = teamsByGoals
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key).Take(3);
            foreach (var goal in goals)
            {
                Console.WriteLine($"- {goal.Key} -> {goal.Value}");
            }
        }

        private static void AddToTeamsByPoints(Dictionary<string, int> teamsByPoints, string team, int points)
        {
            if (teamsByPoints.ContainsKey(team))
                teamsByPoints[team] += points;
            else
                teamsByPoints.Add(team, points);
        }

        private static void AddToTeamsByGoals(Dictionary<string, long> teamsByGoals, string team, int score)
        {
            if (teamsByGoals.ContainsKey(team))
                teamsByGoals[team] += score;
            else
                teamsByGoals.Add(team, score);
        }

        private static string ExtractTeam(string token, string key)
        {
            string result = string.Empty;
            int start = token.IndexOf(key) + key.Length;
            int end = token.LastIndexOf(key);

            result = token.Substring(start, end - start);
            string team = new string(result.Reverse().ToArray());
            return team.ToUpper();
        }
    }
}
