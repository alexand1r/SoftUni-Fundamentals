using System;

namespace Boat
{
    class Boat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bodySize = (n - 1) / 2;

            int innerdots = n - 1;
            int asterisk = 1;
            int outterdots = n;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine(new string('.', innerdots) 
                    + new string('*', asterisk) 
                    + new string('.', outterdots));
                innerdots -= 2;
                asterisk += 2;
            }

            innerdots += 4;
            asterisk -= 4;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', innerdots) 
                    + new string('*', asterisk) 
                    + new string('.', outterdots));
                innerdots += 2;
                asterisk -= 2;
            }

            for (int i = 0; i < bodySize; i++)
            {
                Console.WriteLine(new string('.', i) 
                    + new string('*', 2 * n - 2 * i) 
                    + new string('.', i));
            }
        }
    }
}
