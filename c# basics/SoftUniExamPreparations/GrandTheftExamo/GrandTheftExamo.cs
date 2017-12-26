using System;

namespace GrandTheftExamo
{
    class GrandTheftExamo
    {
        static void Main(string[] args)
        {
            int attempts = int.Parse(Console.ReadLine());
            long tSlapped = 0;
            long tEscaped = 0;
            long beers = 0;

            for (int i = 0; i < attempts; i++)
            {
                int thieves = int.Parse(Console.ReadLine());
                int bottles = int.Parse(Console.ReadLine());

                if (thieves > 5)
                {
                    tEscaped += thieves - 5;
                    tSlapped += 5;
                }
                else
                {
                    tSlapped += thieves;
                }

                beers += bottles;
            }
            Console.WriteLine("{0} thieves slapped.", tSlapped);
            Console.WriteLine("{0} thieves escaped.", tEscaped);
            Console.WriteLine("{0} packs, {1} bottles.", beers / 6, beers % 6);
        }
    }
}
