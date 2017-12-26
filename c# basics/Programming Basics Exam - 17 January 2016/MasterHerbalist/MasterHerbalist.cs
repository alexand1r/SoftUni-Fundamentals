using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterHerbalist
{
    class MasterHerbalist
    {
        static void Main(string[] args)
        {
            decimal dailyExpences = decimal.Parse(Console.ReadLine());
            decimal totalMoney = 0;
            int days = 0;
            string command = Console.ReadLine();
            while (command != "Season Over")
            {
                days++;
                int hFound = 0;
                string[] input = command.Split(' ');
                int hours = int.Parse(input[0]);
                string str = input[1];
                decimal money = decimal.Parse(input[2]);

                while (hours > 0 && hours > str.Length)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == 'H')
                        {
                            hFound++;
                        }
                    }
                    hours -= str.Length;
                }
                for (int i = 0; i < hours; i++)
                {
                    if (str[i] == 'H')
                    {
                        hFound++;
                    }
                }

                totalMoney += (decimal)hFound * money;

                command = Console.ReadLine();
            }
            decimal averageMoney = totalMoney / days;
            if (averageMoney >= dailyExpences)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:F2}."
                    , averageMoney - dailyExpences);
            }
            else
            {
                Console.WriteLine("We are in the red. Money needed: {0}."
                    , (dailyExpences * days) - totalMoney);
            }
        }
    }
}
