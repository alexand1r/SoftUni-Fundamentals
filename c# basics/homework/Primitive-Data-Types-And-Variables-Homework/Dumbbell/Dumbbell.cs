using System;

namespace Dumbbell
{
    class Dumbbell
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string emptyTop = new string('.', n / 2);
            string dumbbellTop = new string('&', n / 2 + 1);
            string middleTop = new string('.', n);
            Console.WriteLine(emptyTop + dumbbellTop + middleTop + dumbbellTop + emptyTop);

            for(int i = 0; i < n / 2 - 1; i++)
            {
                string empty = new string('.', n / 2 - i - 1);
                string dumbbell = "&" + new string('*', n /2 + i) + "&";
                Console.WriteLine(empty + dumbbell + middleTop + dumbbell + empty);
            }

            string bar = new string('=', n);
            string dumbbellCenter = "&" + new string('*', n - 2) + "&";
            Console.WriteLine(dumbbellCenter + bar + dumbbellCenter);

            for(int i = n / 2 - 1; i > 0; i--)
            {
                string empty = new string('.', n / 2 - i);
                string dumbbell = "&" + new string('*', n / 2 + i - 1) + "&";
                Console.WriteLine(empty + dumbbell + middleTop + dumbbell + empty);
            }
            Console.WriteLine(emptyTop + dumbbellTop + middleTop + dumbbellTop + emptyTop);
        }
    }
}
