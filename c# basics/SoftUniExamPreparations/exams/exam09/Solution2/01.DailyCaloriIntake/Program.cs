using System;

class Program
{
    static void Main()
    {
        //Step 1 -> Read the input
        int weightPunds = int.Parse(Console.ReadLine());
        int heightInches = int.Parse(Console.ReadLine());
        int personAge = int.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        int workoutsPerWeek = int.Parse(Console.ReadLine());

        //Step 2 -> Normalize data
        double weightKilos = weightPunds / 2.2D;
        double heightCm = heightInches * 2.54D;

        //Step 3 -> Check the gender of the customer
        //and calculate the BMR
        double bmr = 0.0D;
        if (gender == "m")
        {
            bmr = 66.5 + (13.75 * weightKilos) + (5.003 * heightCm) - (6.755 * personAge);
        }
        else
        {
            bmr = 655 + (9.563 * weightKilos) + (1.850 * heightCm) - (4.676 * personAge);
        }

        //Step 4 -> Determinate the BMR multiplier
        //based on the count of the workouts
        double multiplier = 0.0D;
        if (workoutsPerWeek < 1)
        {
            multiplier = 1.2;
        }
        else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
        {
            multiplier = 1.375;
        }
        else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
        {
            multiplier = 1.55;
        }
        else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
        {
            multiplier = 1.725;
        }
        else
        {
            multiplier = 1.9;
        }

        //Step 4v2 ->
        double muliplier2 = (workoutsPerWeek < 1) ? 1.2 :
            (workoutsPerWeek >= 1 && workoutsPerWeek <= 3) ? 1.375 :
            (workoutsPerWeek >= 4 && workoutsPerWeek <= 6) ? 1.55 :
            (workoutsPerWeek >= 7 && workoutsPerWeek <= 9) ? 1.725 : 1.9;

        //Step 5 -> Calculate DCI
        double dci = Math.Floor(bmr * muliplier2);

        //Step 6 -> Print the output
        Console.WriteLine(dci);
    }
}

