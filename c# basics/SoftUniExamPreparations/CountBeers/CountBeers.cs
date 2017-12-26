using System;

namespace CountBeers
{
    class CountBeers
    {
        static void Main(string[] args)
        {
            int stacks = 0;
            int beers = 0;
            string command = Console.ReadLine();
            
            while (command != "End")
            {
                string[] input = command.Split();
                int number = int.Parse(input[0]);
                string str = input[1];

                if (str == "stacks")
                {
                    stacks += number;
                }
                else
                {
                    beers += number;
                }

                command = Console.ReadLine();
            }

            while (beers >= 20)
            {
                beers -= 20;
                stacks++;
            }

            Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
        }
    }
}
