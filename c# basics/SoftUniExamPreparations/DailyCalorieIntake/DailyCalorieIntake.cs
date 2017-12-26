using System;

namespace DailyCalorieIntake
{
    class DailyCalorieIntake
    {
        static void Main(string[] args)
        {
            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            char G = char.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());

            double weight = W / 2.2d;
            double height = H * 2.54d;

            double mBMR = 66.5d + (13.75d * weight) + (5.003d * height) - (6.755d * A);
            double fBMR = 655 + (9.563d * weight) + (1.850d * height) - (4.676d * A);

            double DCI = 0;
            if (E <= 0)
            {
                DCI = 1.2d;
            }
            else if (E >= 1 && E <= 3)
            {
                DCI = 1.375d;
            }
            else if (E >= 4 && E <= 6)
            {
                DCI = 1.55d;
            }
            else if (E >= 7 && E <=9)
            {
                DCI = 1.725d;
            }
            else
            {
                DCI = 1.9d;
            }

            if (G == 'm')
            {
                Console.WriteLine(Math.Floor(DCI * mBMR));
            }
            else
            {
                Console.WriteLine(Math.Floor(DCI * fBMR));
            }
        }
    }
}
