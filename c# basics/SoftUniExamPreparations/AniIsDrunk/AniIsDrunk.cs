using System;

namespace AniIsDrunk
{
    class AniIsDrunk
    {
        static void Main(string[] args)
        {
            int numberOfCabins = int.Parse(Console.ReadLine());

            long currentPosition = 0;
            long totalLenghtCovered = 0;

            string command = Console.ReadLine();
            while (command != "Found a free one!")
            {
                long steps = long.Parse(command);
                long oldPosition = currentPosition;
                currentPosition = (currentPosition + steps) % numberOfCabins;
                long difference = currentPosition - oldPosition;
                totalLenghtCovered += Math.Abs(difference);

                if (difference > 0)
                {
                    Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(difference));
                }
                else if (difference < 0)
                {
                    Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                }

                command = Console.ReadLine();   
            }

            Console.WriteLine("Moved a total of {0} steps.", totalLenghtCovered);
        }
    }
}
