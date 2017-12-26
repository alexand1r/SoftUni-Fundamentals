using System;
using System.Collections.Generic;

namespace FirefightingOrganization
{
    class FirefightingOrganization
    {
        static void Main(string[] args)
        {
            int firefighters = int.Parse(Console.ReadLine());
            int n = firefighters;
            string line = Console.ReadLine();
            int kidsSaved = 0;
            int adultsSaved = 0;
            int seniorsSaved = 0;

            while  (line != "rain")
            {
                    for (int i = 0; i < line.Length; i++)
                    {
                       if (line[i] == 'K' && firefighters > 0)
                        {
                            kidsSaved++;
                            firefighters--;
                        }
                    }
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == 'A' && firefighters > 0)
                        {
                            adultsSaved++;
                            firefighters--;
                        }
                    }
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == 'S' && firefighters > 0)
                        {
                            seniorsSaved++;
                            firefighters--;
                        }
                    }
                firefighters = n;
                line = Console.ReadLine();
            }

            Console.WriteLine("Kids: {0}", kidsSaved);
            Console.WriteLine("Adults: {0}", adultsSaved);
            Console.WriteLine("Seniors: {0}", seniorsSaved);
        }
    }
}
