using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class OtherSolution
{
    public static void Solution()
    {
        var matchCount = 0;
        var fixtures = new Dictionary<string, int>()
            {
                { "Arsenal", 0 },
                { "Chelsea", 0 },
                { "Everton", 0 },
                { "Liverpool", 0 },
                { "ManchesterCity", 0 },
                { "ManchesterUnited", 0 },
                { "Southampton", 0 },
                { "Tottenham", 0 }
            };

       
        decimal payment = decimal.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        while (input != "End of the league.")
        {
            var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var homeTeam = tokens[0];
            var awayTeam = tokens[2];
            var matchResult = tokens[1];

            if (matchResult == "1")
            {
                fixtures[homeTeam] += 3;
            }
            else if (matchResult == "2")
            {
                fixtures[awayTeam] += 3;
            }
            else
            {
                fixtures[homeTeam] += 1;
                fixtures[awayTeam] += 1;
            }

            matchCount++;
            input = Console.ReadLine();
        }

        decimal income = (payment * 1.94M) * matchCount;
        Console.WriteLine("{0:F2}lv.", income);

        foreach (var fix in fixtures)
        {
            var result = Regex.Match(fix.Key, "[A-Z][a-z]+");
            Console.WriteLine("{0} - {1} points.", "", fix.Value);
        }
    }

}

