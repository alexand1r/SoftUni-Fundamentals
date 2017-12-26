using System;

class Program
{
    static void Main()
    {
        //OtherSolution.Solution();
        int[] fixtures = new int[8];
        int matchCount = 0;

        decimal payment = decimal.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        while (input != "End of the league.")
        {
            string[] tokens = input.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            string homeTeam = tokens[0];
            string matchResult = tokens[1];
            string awayTeam = tokens[2];

            if (matchResult == "1")
            {
                switch (homeTeam)
                {
                    case "Arsenal": fixtures[0] += 3; break;
                    case "Chelsea": fixtures[1] += 3; break;
                    case "Everton": fixtures[2] += 3; break;
                    case "Liverpool": fixtures[3] += 3; break;
                    case "ManchesterCity": fixtures[4] += 3; break;
                    case "ManchesterUnited": fixtures[5] += 3; break;
                    case "Southampton": fixtures[6] += 3; break;
                    case "Tottenham": fixtures[7] += 3; break;
                }
            }
            else if (matchResult == "2")
            {
                switch (awayTeam)
                {
                    case "Arsenal": fixtures[0] += 3; break;
                    case "Chelsea": fixtures[1] += 3; break;
                    case "Everton": fixtures[2] += 3; break;
                    case "Liverpool": fixtures[3] += 3; break;
                    case "ManchesterCity": fixtures[4] += 3; break;
                    case "ManchesterUnited": fixtures[5] += 3; break;
                    case "Southampton": fixtures[6] += 3; break;
                    case "Tottenham": fixtures[7] += 3; break;
                }
            }
            else
            {
                switch (homeTeam)
                {
                    case "Arsenal": fixtures[0] += 1; break;
                    case "Chelsea": fixtures[1] += 1; break;
                    case "Everton": fixtures[2] += 1; break;
                    case "Liverpool": fixtures[3] += 1; break;
                    case "ManchesterCity": fixtures[4] += 1; break;
                    case "ManchesterUnited": fixtures[5] += 1; break;
                    case "Southampton": fixtures[6] += 1; break;
                    case "Tottenham": fixtures[7] += 1; break;
                }

                switch (awayTeam)
                {
                    case "Arsenal": fixtures[0] += 1; break;
                    case "Chelsea": fixtures[1] += 1; break;
                    case "Everton": fixtures[2] += 1; break;
                    case "Liverpool": fixtures[3] += 1; break;
                    case "ManchesterCity": fixtures[4] += 1; break;
                    case "ManchesterUnited": fixtures[5] += 1; break;
                    case "Southampton": fixtures[6] += 1; break;
                    case "Tottenham": fixtures[7] += 1; break;
                }
            }

            matchCount++;
            input = Console.ReadLine();
        }

        decimal income = (payment * 1.94M) * matchCount;

        Console.WriteLine("{0:F2}lv.", income);
        Console.WriteLine(@"Arsenal - {0} points.
Chelsea - {1} points.
Everton - {2} points.
Liverpool - {3} points.
Manchester City - {4} points.
Manchester United - {5} points.
Southampton - {6} points.
Tottenham - {7} points.",
fixtures[0], fixtures[1], fixtures[2], fixtures[3], fixtures[4],
fixtures[5], fixtures[6], fixtures[7]);
    }
}

