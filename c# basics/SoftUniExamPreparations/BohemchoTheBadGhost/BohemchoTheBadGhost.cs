using System;
using System.Collections.Generic;

namespace BohemchoTheBadGhost
{
    class BohemchoTheBadGhost
    {
        static void Main(string[] args)
        {
            long score = 0;
            int lightsSwitched = 0;
            string command = Console.ReadLine();
            while (command != "Stop, God damn it")
            {
                uint floor = uint.Parse(command);
                //int[] currentRooms = Console.ReadLine().Split().Select(int.Parse).ToArray();
                List<int> lights = new List<int>();
                string[] input = Console.ReadLine().Split(' ');
                for (int i = 0; i < input.Length; i++)
                {
                    lights.Add(int.Parse(input[i]));
                }
                
                for (int i = 0; i < lights.Count; i++)
                {
                        uint mask = 1U << lights[i];
                        floor = floor ^ mask;
                }
                for (int i = 0; i < 32; i++)
                {
                    if (Check(floor, i) == 1)
                    {
                        lightsSwitched++;
                    }
                }
                score += floor;

                command = Console.ReadLine();
            }

            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}"
                , lightsSwitched, score);
        }

        static uint Check(uint floor, int light)
        {
            floor >>= light;
            floor &= 1;
            return floor;
        }
    }
}
