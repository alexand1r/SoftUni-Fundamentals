using System;

namespace TheFootballStatistician
{
    class TheFootballStatistician
    {
        static void Main(string[] args)
        {
            decimal payment = decimal.Parse(Console.ReadLine()) * 1.94m;
            int arsenalPoints = 0;
            int chelseaPoints = 0;
            int evertonPoints = 0;
            int liverpoolPoints = 0;
            int manchesterCityPoints = 0;
            int manchesterUnitedPoints = 0;
            int southamptonPoints = 0;
            int tottenhamPoints = 0;
            int matchesCount = 0;
            string command = Console.ReadLine();

            while (command != "End of the league.")
            {
                string[] input = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string team1 = input[0];
                string team2 = input[2];
                string outcome = input[1];
                matchesCount++;
                
                if (outcome == "1")
                {
                    switch (team1)
                    {
                        case "Arsenal": arsenalPoints += 3; break;
                        case "Chelsea": chelseaPoints += 3; break;
                        case "Everton": evertonPoints += 3; break;
                        case "Liverpool": liverpoolPoints += 3; break;
                        case "ManchesterCity": manchesterCityPoints += 3; break;
                        case "ManchesterUnited": manchesterUnitedPoints += 3; break;
                        case "Southampton": southamptonPoints += 3; break;
                        case "Tottenham": tottenhamPoints += 3; break;
                    }
                }
                else if (outcome == "2")
                {
                    switch (team2)
                    {
                        case "Arsenal": arsenalPoints += 3; break;
                        case "Chelsea": chelseaPoints += 3; break;
                        case "Everton": evertonPoints += 3; break;
                        case "Liverpool": liverpoolPoints += 3; break;
                        case "ManchesterCity": manchesterCityPoints += 3; break;
                        case "ManchesterUnited": manchesterUnitedPoints += 3; break;
                        case "Southampton": southamptonPoints += 3; break;
                        case "Tottenham": tottenhamPoints += 3; break;
                    }
                }
                else if (outcome == "X")
                {
                    switch (team1)
                    {
                        case "Arsenal": arsenalPoints++; break;
                        case "Chelsea": chelseaPoints++; break;
                        case "Everton": evertonPoints++; break;
                        case "Liverpool": liverpoolPoints++; break;
                        case "ManchesterCity": manchesterCityPoints++; break;
                        case "ManchesterUnited": manchesterUnitedPoints++; break;
                        case "Southampton": southamptonPoints++; break;
                        case "Tottenham": tottenhamPoints++; break;
                    }
                    switch (team2)
                    {
                        case "Arsenal": arsenalPoints++; break;
                        case "Chelsea": chelseaPoints++; break;
                        case "Everton": evertonPoints++; break;
                        case "Liverpool": liverpoolPoints++; break;
                        case "ManchesterCity": manchesterCityPoints++; break;
                        case "ManchesterUnited": manchesterUnitedPoints++; break;
                        case "Southampton": southamptonPoints++; break;
                        case "Tottenham": tottenhamPoints++; break;
                    }
                }

                command = Console.ReadLine();
            }

            decimal money = payment * matchesCount;

            Console.WriteLine("{0:F2}lv.", money);
            Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
            Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
            Console.WriteLine("Everton - {0} points.", evertonPoints);
            Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
            Console.WriteLine("Manchester City - {0} points.", manchesterCityPoints);
            Console.WriteLine("Manchester United - {0} points.", manchesterUnitedPoints);
            Console.WriteLine("Southampton - {0} points.", southamptonPoints);
            Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);
        }
    }
}
