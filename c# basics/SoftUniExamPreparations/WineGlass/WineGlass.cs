using System;

namespace WineGlass
{
    class WineGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n;
            int height = n;
            int asterisk = n - 2;
            int dots = 1;

            Console.WriteLine("\\{0}/", new string('*', asterisk));
            asterisk -= 2;
            height--;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('.', dots), new string('*', asterisk));
                asterisk -= 2;
                dots++;
                height--;
            }
            dots--;
            int amount = 0;
            if (n >= 12)
            {
                amount = n / 2 - 2;
            }
            else
            {
                amount = n / 2 - 1;
            }
            for(int i = 0; i < amount; i++)
            {
                Console.WriteLine("{0}||{0}", new string('.', dots));
                height--;
            }
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("{0}", new string('-', width));
            }
        }
    }
}
