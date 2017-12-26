using System;

namespace FourFactors
{
    class FourFactors
    {
        static void Main(string[] args)
        {
            double fieldGoals = double.Parse(Console.ReadLine());
            double fieldGoalAttempts = double.Parse(Console.ReadLine());
            double threePointFieldGoals = double.Parse(Console.ReadLine());
            double turnovers = double.Parse(Console.ReadLine());
            double offensiveRebounds = double.Parse(Console.ReadLine());
            double opponentDefensiveRebounds = double.Parse(Console.ReadLine());
            double freeThrows = double.Parse(Console.ReadLine());
            double freeThrowAttempts = double.Parse(Console.ReadLine());

            double eFG = (fieldGoals + 0.5 * threePointFieldGoals) / fieldGoalAttempts;
            double TOV = turnovers / (fieldGoalAttempts + 0.44 * freeThrowAttempts + turnovers);
            double ORB = offensiveRebounds / (opponentDefensiveRebounds + offensiveRebounds);
            double FT = freeThrows / fieldGoalAttempts;

            Console.WriteLine("eFG% {0:F3}", eFG);
            Console.WriteLine("TOV% {0:F3}", TOV);
            Console.WriteLine("ORB% {0:F3}", ORB);
            Console.WriteLine("FT% {0:F3}", FT);
        }
    }
}
